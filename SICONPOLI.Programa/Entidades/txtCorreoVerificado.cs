using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PA4IM9_20262_Equipo2.Vistas.PanelesRegistros
{
    public partial class txtCorreoVerificado : UserControl
    {
        int indice;
        public txtCorreoVerificado()
        {
            InitializeComponent();
        }

        private void txtCorreo_Validating(object sender, CancelEventArgs e)
        {
            if (txtCorreo.Text == "Correo") return;
            if (!CorreoValido(txtCorreo.Text) && txtCorreo.Visible == true)
            {
                MessageBox.Show("Ingrese un correo valido.", "Correo no valido.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCorreo.Focus();
            }
        }
        private bool CorreoValido(string cadena)
        {
            string expresionRegular = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(cadena, expresionRegular))
            {
                if (Regex.Replace(cadena, expresionRegular, String.Empty).Length == 0) return true;
                else return false;
            }
            else return false; 
        }

        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            if (txtCorreo.Text != "") return;
            txtCorreo.Text = "Correo";
            txtCorreo.ForeColor = Color.FromArgb(106, 144, 86);
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (txtCorreo.Text != "Correo") return;
            txtCorreo.Text = "";
            txtCorreo.ForeColor = Color.FromArgb(46, 88, 77);
        }

        //
        // Logica de ventos
        //
        public delegate void AutoEliminar(int indice);
        public event AutoEliminar ClickEliminar;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (this.Parent.Controls.Count > 1)
                ClickEliminar?.Invoke(indice);
        }

        private void txtCorreoVerificado_ParentChanged(object sender, EventArgs e)
        {
            if (this.Parent != null) indice = this.Parent.Controls.Count;
        }
    }
}
