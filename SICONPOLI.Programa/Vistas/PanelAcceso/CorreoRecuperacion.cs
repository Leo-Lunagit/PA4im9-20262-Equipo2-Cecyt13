using PA4IM9_20262_Equipo2.Modulos;
using PA4IM9_20262_Equipo2.Entidades;
using PA4IM9_20262_Equipo2.Vistas.CamposSubCuentas;
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
using MimeKit;

namespace PA4IM9_20262_Equipo2.Vistas.PanelAcceso
{
    public partial class CorreoRecuperacion : Form
    {
        public CorreoRecuperacion()
        {
            InitializeComponent();

            lblLorem.TabStop = true;
        }

        //
        // Logica de utilidades
        //
        private void QuitarPlaceHolder(object Sender, string PlaceHolder)
        {
            // Transforma el objeto enviado en un control.
            Control caja = Sender as Control;
            if (caja.Text == PlaceHolder)
            {
                // Si el texto es igual al "placeholder" lo borra. 
                caja.Text = "";
                // Y le da un color nitido.
                caja.ForeColor = Color.FromArgb(46, 88, 77);
            }
        }
        private void PonerPlaceHolder(object Sender, string PlaceHolder)
        {
            Control caja = Sender as Control;
            if (caja.Text == "")
            {
                // Si el texto esta vacio da el texto del placeholder.
                caja.Text = PlaceHolder;
                // Y regresa el color claro.
                caja.ForeColor = Color.FromArgb(106, 144, 86);
            }
        }
        
        private void txtNombre_Enter(object sender, EventArgs e) { QuitarPlaceHolder(sender, "Nombre"); }
        private void txtUsuario_Enter(object sender, EventArgs e) { QuitarPlaceHolder(sender, "Usuario"); }
        private void txtCorreo_Enter(object sender, EventArgs e) { QuitarPlaceHolder(sender, "Email"); }
        private void txtNombre_Leave(object sender, EventArgs e) { PonerPlaceHolder(sender, "Nombre"); }
        private void txtUsuario_Leave(object sender, EventArgs e) { PonerPlaceHolder(sender, "Usuario"); }
        private void txtCorreo_Leave(object sender, EventArgs e) { PonerPlaceHolder(sender, "Email"); }
        //
        // Logica de envio de correo.
        //

        private bool CamposCompletos()
        {
            bool Completos = txtNombre.Text != "Nombre" || txtUsuario.Text != "Usuario" || txtCorreo.Text != "Email";
            return Completos;
        }
        
        private async void btnAcceder_Click(object sender, EventArgs e)
        {
            if (!CamposCompletos()) 
            {
                MessageBox.Show("Completa todos los campos por favor.", "Incompleto.", MessageBoxButtons.OK);
                return; 
            }

            Sistema.VerificarArchivo(Rutas.Usuarios, Raices.Usuarios);
            XmlDocument lector = new XmlDocument();
            lector.Load(Rutas.Usuarios);

            XmlNode PerfilEncontrado = lector.SelectSingleNode($"//perfil[nombre='{txtNombre.Text}' or usuario='{txtUsuario.Text}' or correo='{txtCorreo.Text}'] ");
            if (PerfilEncontrado == null) 
            {
                MessageBox.Show("Los datos ingresados no coinciden con ningun perfil. Por favor registrese.", "Datos no encontrados.", MessageBoxButtons.OK);
                return;
            }

            Perfil Usuario = ConvertidorXml.ElementoToObjeto<Perfil>((XmlElement)PerfilEncontrado);

            if (txtNombre.Text != Usuario.Nombre || txtUsuario.Text != Usuario.Usuario || txtCorreo.Text != Usuario.Correo)
            {
                MessageBox.Show("Los datos ingresados no coinciden con el perfil, por favor rectifiquelos y vuelva a intentar.", "Datos no coincidentes", MessageBoxButtons.OK);
                return;
            }

            PaqueteRecuperacion Paquete = new PaqueteRecuperacion
            {
                Nombre = Usuario.Nombre,
                Usuario = Usuario.Usuario,
                Correo = Usuario.Correo,
                Contrasenia = Usuario.Contrasenia
            };

            string CuerpoHtml = PlantillasCorreo.Recuperacion(Paquete);

            Correo Correo = new Correo
            {
                Destinatario = new MailboxAddress(Paquete.Nombre, Paquete.Correo),
                Asunto = "Recuperación de Contraseña. | SIRETECH Poli.",
                MensajeHtml = CuerpoHtml,
            };

            await Cartero.EnviarCorreo(Correo);
            this.Close();
        }
    }
}
