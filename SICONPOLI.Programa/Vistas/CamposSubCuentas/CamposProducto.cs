using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using PA4IM9_20262_Equipo2.Entidades;
using PA4IM9_20262_Equipo2.Modulos;
using PA4IM9_20262_Equipo2.Vistas.Catalogos;

namespace PA4IM9_20262_Equipo2.Vistas.CamposSubCuentas
{
    public partial class CamposProducto : Campos
    {
        Cuentas CuentaTitular;
        private bool Restrictivo;

        public CamposProducto(Cuentas cuentaTitular)
        {
            InitializeComponent();
            CompletarCampos(cuentaTitular);
        }
        private void CompletarCampos(Cuentas cuentaTitular)
        {
            Cuenta = Cuentas.Almacen;
            CuentaTitular = cuentaTitular;
            Restrictivo = CuentaTitular == Cuentas.Clientes;
            Sistema.VerificarArchivo(Rutas.Productos, Raices.Productos);
            XmlDocument lecto = new XmlDocument();
            lecto.Load(Rutas.Productos);

            if (Restrictivo)
            {
                cmbNombreItem.DropDownStyle = ComboBoxStyle.DropDownList;
                txtCostoUni.ReadOnly = true;
            }

            if (MEMORIA.Productos == null || MEMORIA.Productos.Length < 1) return;
            foreach (PaqueteAlmacen producto in MEMORIA.Productos)
                cmbNombreItem.Items.Add(producto.Producto);
        }
        //
        // Logica de validaciones
        //
        private void txtCostoUni_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;

            // 1. Permitir números, borrar, espacios y el punto (si no existe ya)
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back) e.Handled = false;
            else if (e.KeyChar == '.' && !txt.Text.Contains(".")) e.Handled = false;
            else { e.Handled = true; return; }

            // 2. Controlar las 2 cifras decimales (solo si ya hay punto y no estás borrando)
            if (!e.Handled && txt.Text.Contains(".") && char.IsDigit(e.KeyChar))
            {
                int indice = txt.Text.IndexOf('.');
                // Bloquea solo si el cursor está parado después del punto y ya hay 2 dígitos
                if (txt.SelectionLength > 0 && txt.SelectionStart >= indice) return;
                if (txt.SelectionStart > indice)
                {
                    string decimales = txt.Text.Substring(indice + 1);
                    if (decimales.Length >= 2)
                        e.Handled = true;
                }
            }
        }
        //
        // Logica de dinamismo.
        //
        private void txtCostoUni_TextChanged(object sender, EventArgs e) { CalcularCosto(); }
        private void nudCantidad_ValueChanged(object sender, EventArgs e) { CalcularCosto(); }
        private void CalcularCosto()
        {
            if (txtCostoUni.Text == "" || txtCostoUni.Text == ".") txtMonto.Text = "";
            else
            {
                decimal CostoUnitario;
                try { CostoUnitario = decimal.Parse(txtCostoUni.Text); }
                catch { CostoUnitario = decimal.Parse(txtCostoUni.Text, NumberStyles.Currency, CultureInfo.CurrentCulture); }
                decimal Cantidad = nudCantidad.Value;

                decimal CostoFinal = CostoUnitario * Cantidad;
                txtMonto.Text = $"{CostoFinal:C}";
                }
        }
        //
        // Logica de validacion.
        //
        public override bool CamposCompletos(bool Hermanos)
        {
            if (Hermanos && CampoNulo())
                return true;

            bool Completos = cmbNombreItem.Text != "" && txtCostoUni.Text != "" && nudCantidad.Text != "";
            return Completos;
        }
        public override bool CampoNulo()
        {
            base.CampoNulo();
            bool CampoNulo = nudCantidad.Value == 1 && cmbNombreItem.Text == "" && txtCostoUni.Text == "";
            return CampoNulo;
        }

        private void cmbNombreItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtCostoUni.Text != "" && !Restrictivo) return;

            string NombreProducto = cmbNombreItem.Text;
            PaqueteAlmacen paquete = MEMORIA.Productos.First(producto => producto.Producto == $"{NombreProducto}");
            decimal costo = paquete.CostoUnitario;
            txtCostoUni.Text = $"{(costo / 100):C2}";

            if (Restrictivo) nudCantidad.Maximum = paquete.Stock;
        }
    }
}
