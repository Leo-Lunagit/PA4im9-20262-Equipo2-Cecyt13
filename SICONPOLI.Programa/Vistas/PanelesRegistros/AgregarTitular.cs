using PA4IM9_20262_Equipo2.Entidades;
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
using System.Xml;

namespace PA4IM9_20262_Equipo2.Vistas.PanelesRegistros
{
    public partial class AgregarTitular : Form
    {
        private Cuentas Cuenta;
        public AgregarTitular(string Nombre, Cuentas cuenta)
        {
            InitializeComponent();
            CompletarComponentes(Nombre, cuenta);
        }
        private void CompletarComponentes(string Nombre, Cuentas cuenta)
        {
            Cuenta = cuenta;
            cmbCreditos.SelectedIndex = 0;
            if (Nombre == "")
                txtNombre.ReadOnly = false;
            else
            {
                txtNombre.Text = Nombre;
                cmbCreditos.SelectedIndex = 0;
            }
        }

        private void cmbCreditos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCreditos.SelectedIndex == 0)
            {
                txtCredito.Text = cmbCreditos.Items[0].ToString();
                txtCredito.ReadOnly = true;
            }
            else if (cmbCreditos.SelectedIndex == 1)
            {
                txtCredito.Text = cmbCreditos.Items[1].ToString();
                txtCredito.ReadOnly = true;
            }
            else
            {
                txtCredito.Text = "";
                txtCredito.ReadOnly = false;
                txtCredito.Focus();
            }
        }

        // 
        // Logica de Hovers.
        //
        private void QuitarPlaceHolder(TextBox caja, string PlaceHolder)
        {
            if (caja.Text == PlaceHolder)
            {
                // Si el texto es igual al "placeholder" lo borra. 
                caja.Text = "";
                // Y le da un color nitido.
                caja.ForeColor = Color.FromArgb(46, 88, 77);
            }
        }
        private void PonerPlaceHolder(TextBox caja, string PlaceHolder)
        {
            if (caja.Text == "")
            {
                // Si el texto esta vacio da el texto del placeholder.
                caja.Text = PlaceHolder;
                // Y regresa el color claro.
                caja.ForeColor = Color.FromArgb(106, 144, 86);
            }
        }
        //
        // QuitarPlaceHolders
        //
        private void txtNombre_Enter(object sender, EventArgs e) { QuitarPlaceHolder(txtNombre, "Nombre"); }
        private void txtCredito_Enter(object sender, EventArgs e) { QuitarPlaceHolder(txtCredito, "Credito"); }
        private void txtDireccion_Enter(object sender, EventArgs e) { QuitarPlaceHolder(txtDireccion, "Direccion"); }
        private void txtCorreo_Enter(object sender, EventArgs e) { QuitarPlaceHolder(txtCorreo, "Email"); }
        private void txtTelefono_Enter(object sender, EventArgs e) { QuitarPlaceHolder(txtTelefono, "Telefono"); }
        private void txtImagen_Enter(object sender, EventArgs e) { QuitarPlaceHolder(txtLinkImagen, "Enlace a Logotipo"); }
        //
        // PonerPlaceHolders
        //
        private void txtNombre_Leave(object sender, EventArgs e) { PonerPlaceHolder(txtNombre, "Nombre"); }
        private void txtCredito_Leave(object sender, EventArgs e) { PonerPlaceHolder(txtCredito, "Credito"); }
        private void txtDireccion_Leave(object sender, EventArgs e) { PonerPlaceHolder(txtDireccion, "Direccion"); }
        private void txtCorreo_Leave(object sender, EventArgs e) { PonerPlaceHolder(txtCorreo, "Email"); }
        private void txtTelefono_Leave(object sender, EventArgs e) { PonerPlaceHolder(txtTelefono, "Telefono"); }
        private void txtImagen_Leave(object sender, EventArgs e) { PonerPlaceHolder(txtLinkImagen, "Enlace a Logotipo"); }
        //
        // Logica de validacion.
        //
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
        private bool VerificarCampos()
        {
            bool completos =
                txtNombre.Text != "Nombre" &&
                !(chkCredito.Checked == true && txtCredito.Text == "Credito") &&
                !(chkDireccion.Checked == true && txtDireccion.Text == "Direccion") &&
                !(chkCorreo.Checked == true && txtCorreo.Text == "Email") &&
                !(chkTelefono.Checked == true && txtTelefono.Text == "Telefono") &&
                !(chkImagen.Checked == true && txtLinkImagen.Text == "Enlace a Logotipo");
            return completos;
        }

        private void txtCorreo_Validating(object sender, CancelEventArgs e)
        {
            if (txtCorreo.Text == "Email" || txtCorreo.Text == "") return;
            else if (!CorreoValido(txtCorreo.Text))
            {
                MessageBox.Show("Ingrese un correo valido o limpie el campo.", "Correo Invalido.", MessageBoxButtons.OK);
                txtCorreo.Focus();
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (!VerificarCampos())
            {
                MessageBox.Show("Por favor completa los campos que deseas.", "Campos Incompletos.", MessageBoxButtons.OK);
                return;
            }

            string rutaPaquete = Cuenta == Cuentas.Proveedores ? Rutas.Proveedores : Rutas.Clientes;
            string raizPaquete = Cuenta == Cuentas.Proveedores ? Raices.Proveedores : Raices.Clientes;
            Sistema.VerificarArchivo(rutaPaquete, raizPaquete);
            XmlDocument escritor = new XmlDocument();
            escritor.Load(rutaPaquete);

            string rutaMayor = Cuenta == Cuentas.Proveedores ? Rutas.MayoresProveedores : Rutas.MayoresClientes;
            string raizMayor = Cuenta == Cuentas.Proveedores ? Raices.MayoresProveedores : Raices.MayoresClientes;
            Sistema.VerificarArchivo(rutaMayor, raizMayor);
            escritor.Load(rutaMayor);

            Contactos Contacto = new Contactos
            {
                Correo = chkCorreo.Checked ? txtCorreo.Text : "",
                Domicilio = chkDireccion.Checked ? txtDireccion.Text : "",
                Telefono = chkTelefono.Checked ? txtTelefono.Text : "",
                LinkImagen = chkImagen.Checked ? txtLinkImagen.Text : ""
            };

            Mayor titular = new Mayor
            {
                Cuenta = Cuenta.ToString(),
                NoTargeta = Sistema.GenerarID(rutaMayor, raizMayor, 3),
                Titular = txtNombre.Text,
                DatosContacto = Contacto,
                LimiteCredito = chkCredito.Checked ? txtCredito.Text : "Sin Aclarar",
            };

            PaqueteTitular paqueteTitular = titular.ToPaquete();

            XmlElement nuevoTitular = ConvertidorXml.ObjetoToElemento(escritor, titular);
            escritor.DocumentElement.AppendChild(nuevoTitular);
            escritor.Save(rutaMayor);

            escritor.Load(rutaPaquete);
            XmlElement nuevoPaquete = ConvertidorXml.ObjetoToElemento(escritor, paqueteTitular);
            escritor.DocumentElement.AppendChild(nuevoPaquete);
            escritor.Save(rutaPaquete);

            this.Close();
        }
    }
}
