using Microsoft.Win32;
using PA4IM9_20262_Equipo2.Entidades;
using PA4IM9_20262_Equipo2.Modulos;
using PA4IM9_20262_Equipo2.Vistas.Panel_Principal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace PA4IM9_20262_Equipo2.Vistas.PanelVentas
{
    public partial class Panel_Ventas : Form
    {
        public Panel_Ventas()
        {
            InitializeComponent();

            // Selecciona el primer prodcutro por defecto.
            cmbProductos.SelectedIndex = 0;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // 1. Validar que el campo Cliente no esté vacío
            if (string.IsNullOrWhiteSpace(txtCliente.Text))
            {
                MessageBox.Show("Por favor, ingresa el nombre del cliente.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtFactura.Text))
            {
                MessageBox.Show("Por favor, ingresa el numnero de la factura.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            // 2. Capturar los datos de los controles
            int cantidad = (int)nudCantidad.Value;
            decimal costoUnitario = (int)nudCostoUnitario.Value;
            string Cliente = txtCliente.Text.Trim();
            decimal subtotal = cantidad * costoUnitario;
            decimal iva = subtotal * .16m;
            string folio = Sistema.GenerarID(Sistema.rutaVentas, Sistema.raizVentas, 3);
            int factura = int.Parse(txtFactura.Text);

            string concepto = $"Venta de mercancia s/f {factura}.";
            
            // 3. Calcular el total de esta subcuenta específica
            decimal totalProducto = subtotal + iva;

            // 7. Muestra Datos en la forma
            txtConcepto.Text = concepto.ToString();
            txtIVA.Text = iva.ToString();
            txtPrecioFinal.Text = totalProducto.ToString();
            txtFolio.Text = folio.ToString();

            btnConfirmar.Enabled = true;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            // 1. Capturar los datos de los controles
            string productos = cmbProductos.SelectedItem.ToString();
            int cantidad = (int)nudCantidad.Value;
            decimal costoUnitario = nudCostoUnitario.Value;
            string Cliente = txtCliente.Text.Trim();
            int factura = int.Parse(txtFactura.Text);
            decimal subtotal = cantidad * costoUnitario;
            decimal iva = subtotal * .16m;
            DateTime fecha = DateTime.Now;
            string usuario = Sistema.PerfilActivo.Usuario;
            string concepto = $"Venta de mercancia s/f {factura}.";
            string folio = Sistema.GenerarID(Sistema.rutaVentas, Sistema.raizVentas, 3);

            // 2. Calcular el total de esta subcuenta específica
            decimal totalProducto = subtotal + iva;

            // 3. Agregar la fila al DataGridView
            dgvSubcuentas.Rows.Add(fecha, productos, subtotal.ToString("C2"), iva.ToString("C2"), totalProducto.ToString("C2"), usuario, factura);

            // 4. Recalcular los totales generales de la aplicación
            CalcularTotalesGenerales();

            // 5. Limpiar los campos para la siguiente captura.
            LimpiarCamposCaptura();

            // Crea la subcuenta del almacen y la llenamos con sus datos correspondientes.
            Subcuenta SubAlmacen = new Subcuenta();
            SubAlmacen.Monto = (int)(costoUnitario * 100);
            SubAlmacen.NombreSubcuenta = $"{cantidad} {productos} a ${costoUnitario} c/u";

            // Creamos la cuenta del amacen y la llenamos con sus datos correspondientes.
            Cuenta Almacen = new Cuenta();
            Almacen.Monto = SubAlmacen.Monto;
            Almacen.NombreCuenta = "almacen";
            Almacen.Subcuentas = new Subcuenta[] { SubAlmacen };

            // Creamos la cuenta del IVA y la lenamos con sus datos.
            Cuenta IVA = new Cuenta();
            IVA.Monto = (int)(iva * 100);
            IVA.NombreCuenta = "IVA por Acreditar";

            // Creamos la subcuenta del cliente y la llenamos con sus datos.
            Subcuenta SubCliente = new Subcuenta();
            SubCliente.Monto = (int)(totalProducto * 100);
            SubCliente.NombreSubcuenta = $"{Cliente} s/f {folio}";

            // Creamos la cuenta del probeedor y la llenamos.
            Cuenta cliente = new Cuenta();
            cliente.NombreCuenta = "Clientes";
            cliente.Monto = SubCliente.Monto;
            cliente.Subcuentas = new Subcuenta[] { SubCliente };

            // Creamos el asiento y lo llenamos.
            Asiento registro = new Asiento();
            registro.NoAsiento = folio;
            registro.Fecha = fecha;
            registro.Cargos = new Cuenta[] { Almacen, IVA };
            registro.Abonos = new Cuenta[] { cliente };
            registro.SumaCargos = IVA.Monto + Almacen.Monto;
            registro.SumaAbonos = cliente.Monto;
            registro.Concepto = concepto;

            XmlDocument escritor = new XmlDocument();
            // Transformamos la clase en elemento xml.
            XmlElement asiento = ConvertidorXml.ObjetoToElemento(escritor, registro);

            Sistema.VerificarArchivo(Sistema.rutaVentas, Sistema.raizVentas);
            escritor.Load(Sistema.rutaVentas);

            escritor.DocumentElement.AppendChild(asiento);
            escritor.Save(Sistema.rutaVentas);

            btnConfirmar.Enabled = false;
        }

        private void CalcularTotalesGenerales()
        {
            decimal subtotal = 0;
            const decimal PorcentajeIVA = 0.16m; // Ajustable según la tasa de tu región (ej. 16%)

            // Recorrer cada fila del DataGridView para sumar los totales de los productos
            foreach (DataGridViewRow fila in dgvSubcuentas.Rows)
            {
                if (fila.Cells["totalProductos"].Value != null)
                {
                    // Reemplazamos el símbolo de moneda para poder convertirlo a decimal limpiamente
                    string valorTexto = fila.Cells["totalProductos"].Value.ToString().Replace("$", "");
                    subtotal += Convert.ToDecimal(valorTexto);
                }
            }

            // Calcular IVA y Precio Final
            decimal iva = subtotal * PorcentajeIVA;
            decimal precioFinal = subtotal + iva;

            // Mostrar los resultados formateados como moneda local
            txtIVA.Text = iva.ToString("C2");
            txtPrecioFinal.Text = precioFinal.ToString("C2");
        }

        private void LimpiarCamposCaptura()
        {
            // Restablece los controles superiores para agilizar el rellenado
            if (cmbProductos.Items.Count > 0) cmbProductos.SelectedIndex = 0;
            nudCantidad.Value = 1;
            nudCostoUnitario.Value = 1;
            txtCliente.Clear();
            cmbProductos.Focus(); // Pone el cursor de vuelta en el producto
            txtFolio.Clear();
            txtIVA.Clear();
            txtConcepto.Clear();
            txtPrecioFinal.Clear();
        }

        private void txtFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y la tecla de retroceso
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloquea la entrada
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //Verifica que haya una celda seleccionada
            if(this.dgvSubcuentas.SelectedRows.Count == 1)
            {
                //carga los datos que hay actualmente en los txt a el datagridview
                int filaSeleccionada = dgvSubcuentas.CurrentRow.Index;
                dgvSubcuentas.Rows[filaSeleccionada].Cells[0].Value = DateTime.Now;
                dgvSubcuentas.Rows[filaSeleccionada].Cells[1].Value = cmbProductos.SelectedItem;
                dgvSubcuentas.Rows[filaSeleccionada].Cells[2].Value = ((int)nudCantidad.Value)*(nudCostoUnitario.Value);
                dgvSubcuentas.Rows[filaSeleccionada].Cells[3].Value = ((int)nudCantidad.Value) * (nudCostoUnitario.Value) * (0.16m);
                dgvSubcuentas.Rows[filaSeleccionada].Cells[4].Value = ((int)nudCantidad.Value) * (nudCostoUnitario.Value) * (1.16m);
                dgvSubcuentas.Rows[filaSeleccionada].Cells[5].Value = Sistema.PerfilActivo.Usuario;
            }
            btnConfirmar.Enabled = false;
        }
    }
}