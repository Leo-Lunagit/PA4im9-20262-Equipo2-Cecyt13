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
using PA4IM9_20262_Equipo2.Entidades;

namespace PA4IM9_20262_Equipo2.Vistas.CamposSubCuentas
{
    public partial class CamposProducto : Campos
    {
        public CamposProducto()
        {
            InitializeComponent();
            Cuenta = Cuentas.Almacen;
        }
        //
        // Logica de validaciones
        //
        private void txtCostoUni_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;

            // 1. Permitir números, borrar, espacios y el punto (si no existe ya)
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsSeparator(e.KeyChar)) e.Handled = false;
            else if (e.KeyChar == '.' && !txt.Text.Contains(".")) e.Handled = false;
            else e.Handled = true;

            // 2. Controlar las 2 cifras decimales (solo si ya hay punto y no estás borrando)
            if (!e.Handled && txt.Text.Contains(".") && !char.IsControl(e.KeyChar))
            {
                // Bloquea solo si el cursor está parado después del punto y ya hay 2 dígitos
                if (txt.SelectionStart > txt.Text.IndexOf('.') && txt.Text.Length - txt.Text.IndexOf('.') > 2)
                    e.Handled = true;
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
                decimal CostoUnitario = decimal.Parse(txtCostoUni.Text);
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
            
            bool Completos = cmbNombreItem.Text != "" && txtCostoUni.Text != "";
            return Completos;
        }
        public override bool CampoNulo()
        {
            base.CampoNulo();
            bool CampoNulo = nudCantidad.Value == 1 && cmbNombreItem.Text == "" && txtCostoUni.Text == "";
            return CampoNulo;
        }
    }
}
