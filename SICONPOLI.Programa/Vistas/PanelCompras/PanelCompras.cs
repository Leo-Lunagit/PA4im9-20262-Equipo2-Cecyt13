using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PA4IM9_20262_Equipo2
{
    public partial class Panel_de_compras : Form
    {
        public Panel_de_compras()
        {
            InitializeComponent();
        }

        private void Panel_de_compras_Load(object sender, EventArgs e)
        {
            // 1. Agregar productos de ejemplo al ComboBox
            cmbProductos.Items.Add("Laptop");
            cmbProductos.Items.Add("Monitor");
            cmbProductos.Items.Add("Procesador de baja calidad");
            cmbProductos.Items.Add("Procesador de media calidad");
            cmbProductos.Items.Add("Procesador de alta calidad");
            cmbProductos.Items.Add("Dispositivos Inteligentes");
            cmbProductos.SelectedIndex = 0; // Selecciona el primero por defecto

            // 2. Configurar las propiedades de los controles numéricos
            nudCantidad.Minimum = 1;
            nudCostoUnitario.DecimalPlaces = 2;
            nudCostoUnitario.Maximum = 100000;

            // 3. Configurar las columnas del DataGridView (el apartado de subcuentas)
            dgvSubcuentas.Columns.Add("Producto", "Producto");
            dgvSubcuentas.Columns.Add("Cantidad", "Cantidad");
            dgvSubcuentas.Columns.Add("CostoUnitario", "Costo Unitario");
            dgvSubcuentas.Columns.Add("Total", "Total Producto");
            dgvSubcuentas.Columns.Add("Proveedor", "Proveedor");

            // Ajuste estético para que las columnas ocupen todo el ancho disponible
            dgvSubcuentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
        
            // 1. Validar que el campo Proveedor no esté vacío
            if (string.IsNullOrWhiteSpace(txtProveedor.Text))
            {
                MessageBox.Show("Por favor, ingresa el nombre del proveedor.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Capturar los datos de los controles
            string producto = cmbProductos.SelectedItem.ToString();
            int cantidad = (int)nudCantidad.Value;
            decimal costoUnitario = nudCostoUnitario.Value;
            string proveedor = txtProveedor.Text.Trim();

            // 3. Calcular el total de esta subcuenta específica
            decimal totalProducto = cantidad * costoUnitario;

            // 4. Agregar la fila al DataGridView
            dgvSubcuentas.Rows.Add(producto, cantidad, costoUnitario.ToString("C2"), totalProducto.ToString("C2"), proveedor);

            // 5. Recalcular los totales generales de la aplicación
            CalcularTotalesGenerales();

            // 6. Limpiar los campos para la siguiente captura (Libertad creativa de UX)
            LimpiarCamposCaptura();
        }
        private void CalcularTotalesGenerales()
        {
            decimal subtotal = 0;
            const decimal PorcentajeIVA = 0.16m; // Ajustable según la tasa de tu región (ej. 16%)

            // Recorrer cada fila del DataGridView para sumar los totales de los productos
            foreach (DataGridViewRow fila in dgvSubcuentas.Rows)
            {
                if (fila.Cells["Total"].Value != null)
                {
                    // Reemplazamos el símbolo de moneda para poder convertirlo a decimal limpiamente
                    string valorTexto = fila.Cells["Total"].Value.ToString().Replace("$", "");
                    subtotal += Convert.ToDecimal (valorTexto);
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
            nudCostoUnitario.Value = 0;
            txtProveedor.Clear();
            cmbProductos.Focus(); // Pone el cursor de vuelta en el producto
        }
    }
    }
