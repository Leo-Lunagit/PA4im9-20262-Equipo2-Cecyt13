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

        private void PanelVentas_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // 1. Validar que el campo Cliente no esté vacío
            if (string.IsNullOrWhiteSpace(txtCliente.Text))
            {
                MessageBox.Show("Por favor, ingresa el nombre del cliente.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Capturar los datos de los controles
            string productos = cmbProductos.SelectedItem.ToString();
            int cantidad = (int)nudCantidad.Value;
            decimal costoUnitario = nudCostoUnitario.Value;
            string Cliente = txtCliente.Text.Trim();
            string folio = Sistema.GenerarFolio();
            decimal subtotal = (cantidad * costoUnitario);
            decimal iva = cantidad * costoUnitario * (decimal).16;
            string fecha = "00:00";
            string usuario = Sistema.PerfilActivo.Usuario; 
            

            // 3. Calcular el total de esta subcuenta específica
            decimal totalProducto = (cantidad * costoUnitario) * 1.16m;

            // 4. Agregar la fila al DataGridView
            dgvSubcuentas.Rows.Add(fecha, productos, subtotal.ToString("C2"), iva, totalProducto.ToString("C2"), usuario, folio);

            // 5. Recalcular los totales generales de la aplicación
            CalcularTotalesGenerales();

            // 6. Limpiar los campos para la siguiente captura.
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
            IVA.Monto = (int)(totalProducto * 16);
            IVA.NombreCuenta = "IVA por Acreditar";

            // Creamos la subcuenta del cliente y la llenamos con sus datos.
            Subcuenta SubCliente = new Subcuenta();
            SubCliente.Monto = (int)(totalProducto * 116);
            SubCliente.NombreSubcuenta = $"{Cliente} s/f 9999";

            // Creamos la cuenta del probeedor y la llenamos.
            Cuenta cliente = new Cuenta();
            cliente.NombreCuenta = "Clientes";
            cliente.Monto = SubCliente.Monto;
            cliente.Subcuentas = new Subcuenta[] { SubCliente };

            // Creamos el asiento y lo llenamos.
            Asiento registro = new Asiento();
            registro.NoAsiento = 999;
            registro.Fecha = DateTime.Now;
            registro.Cargos = new Cuenta[] { Almacen, IVA };
            registro.Abonos = new Cuenta[] { cliente };
            registro.SumaCargos = IVA.Monto + Almacen.Monto;
            registro.SumaAbonos = cliente.Monto;
            registro.Concepto = $"Compra de mercancia s/f XXXX del proveedor {cliente}.";

            XmlDocument escritor = new XmlDocument();
            // Transformamos la clase en elemento xml.
            XmlElement asiento = ConvertidorXml.ObjetoToElemento(escritor, registro);

            Sistema.VerificarArchivo(Sistema.rutaVentas, Sistema.raizVentas);
            escritor.Load(Sistema.rutaVentas);

            escritor.DocumentElement.AppendChild(asiento);
            escritor.Save(Sistema.rutaVentas);
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
            txtTotalProductos.Text = subtotal.ToString("C2");
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
        }
    }
}
