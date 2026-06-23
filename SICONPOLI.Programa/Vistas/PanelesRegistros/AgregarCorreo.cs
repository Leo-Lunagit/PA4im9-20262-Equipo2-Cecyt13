using PA4IM9_20262_Equipo2.Modulos;
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
    public partial class AgregarCorreo : Form
    {
        public string[] CorreosAgregados;
        private static string[] mensajes = { "No se encontro el contacto del titular, por favor agrege un correo.", "Agregue un correo extra para recibir el tiket electronico." };
        public AgregarCorreo(string[] correos, bool SinDesidir)
        {
            CorreosAgregados = correos;
            InitializeComponent();

            lblMensaje.Text = SinDesidir ? AgregarCorreo.mensajes[0] : AgregarCorreo.mensajes[1];
        }
        private void EliminarCorreo(int indice)
        {
            Correos.Controls.RemoveAt(indice - 1);
        }
            

        private void btnAgregarCorreo_Click(object sender, EventArgs e)
        {
            Sistema.IndexarControles(this, Correos, new txtCorreoVerificado(),
                new EnlaceEventos[] { new EnlaceEventos { Controlador = "ClickEliminar", Evento = "EliminarCorreo" } }, 
                DockStyle.None);
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            foreach (txtCorreoVerificado correo in Correos.Controls)
                CorreosAgregados = CorreosAgregados.Append(correo.txtCorreo.Text).ToArray();
            this.Close();
        }
    }
}
