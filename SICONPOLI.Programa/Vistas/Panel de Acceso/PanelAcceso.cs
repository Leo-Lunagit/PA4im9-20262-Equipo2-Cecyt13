using PA4IM9_20262_Equipo2.Modulos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace PA4IM9_20262_Equipo2
{
    public partial class PanelAcceso : Form
    {
        //
        // Logica de carga.
        //
        public PanelAcceso()
        {
            InitializeComponent();
            RecordarUsuario();
        }
        private void RecordarUsuario()
        {
            XmlDocument lector = new XmlDocument(); // Crea el controlador de archivos xml.
            lector.Load(Sistema.rutaUsuarios); // Carga el archivo de usuarios

            // Busca elementos con las coincidenias especificadas y los debuelve en una arreglo.
            // 'lector' -> Contiene el archivo. 'DocumentElement' -> Elemento raiz. '//' -> Ruta actual. "perfil" -> Todos los elementos de nombre perfil.
            // "@" -> Atributos. 'recordado' -> La bandera para recordar el perfil. Resultado: Todos los elementos "perfil" con atributo "recordado".
            XmlNode perfilRecordado = lector.DocumentElement.SelectSingleNode("./perfil[@recordado]");
            // Si existe dicho elemento:
            if (perfilRecordado != null)
            {
                // ["texto"] -> Elemento hijo con tal nombre. "InnerText" -> Su propiedad de texto, USAR ESTA Y NO "Value".
                txtUsuario.Text = perfilRecordado["usuario"].InnerText;
                txtContrasenia.Text = perfilRecordado["contrasenia"].InnerText;
                chkBoxRecordar.Checked = true;
            }
        }
        //
        // Logica de logueo.
        //
        private void btnAcceder_Click(object sender, EventArgs e)
        {
            // Verifica que SOLO los campos neseasarios No esten vacíos.
            if (txtUsuario.Text == "" || txtContrasenia.Text == "" || (txtNombre.Text == "" && txtNombre.Visible == true))
            {
                // Si estan vacíos notifica con un texto y termina el proseso.
                lblMensajes.Text = "Campos vacios.";
                return;
            }
            // EN CASO DE QUE NO ESTEN VACÍOS.
            lblMensajes.Text = ""; // Limpia el mensaje.

            Sistema.VerificarArchivo(Sistema.rutaUsuarios, "usuarios"); // Verifica la existencia del archivo
            // Crea el controlador de archivos xml y carga el documento en la ruta de usuarios.
            XmlDocument documento = new XmlDocument();
            documento.Load(Sistema.rutaUsuarios);

            // Dependiendo del contenido en el boton enviara a inicios o registros de secion.
            if (btnAcceder.Text == "Iniciar Sesión") IniciarSesion(documento, txtUsuario.Text, txtContrasenia.Text);
            else if (btnAcceder.Text == "Registrarse") Registrarse(documento, txtNombre.Text, txtUsuario.Text, txtContrasenia.Text);
        }
        private void IniciarSesion(XmlDocument lector, string usuario, string contrasenia)
        {
            // Si en el elemento raiz del archivo existen registros:
            if (lector.DocumentElement.ChildNodes.Count > 0)
            {
                // Recorrera cada registro.
                foreach (XmlElement elemento in lector.DocumentElement.ChildNodes)
                {
                    // Verificara si los datos ingresados coinciden con los datos del registro.
                    if (elemento["usuario"].InnerText == usuario && elemento["contrasenia"].InnerText == contrasenia)
                    {
                        // Se verifica la casilla de de recordar para guardar una BANDERA en el elemento en forma de atributo, para poder recordarlo.
                        if (chkBoxRecordar.Checked == true)
                        {
                            elemento.Attributes.Append(lector.CreateAttribute("recordado"));
                            lector.Save(Sistema.rutaUsuarios);
                        }
                        else if (elemento.HasAttribute("recordado"))
                        {
                            // Si el elemento tiene el recordar, se lo quita y guarda los cambios.
                            // De sus atributos elimina el atributo de nombre recordado. Por regla de la clase se debe usar forzosamente un atributo.
                            elemento.Attributes.RemoveNamedItem("recordado");
                            lector.Save(Sistema.rutaUsuarios);
                        }
                        // Mandar a llamar al menu principal.
                        MessageBox.Show("Datos correctos. | Accediste al sistema.", "Acceso Permitido.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Si ya se abrio la ventana, se detiene el proseso y se debe cerrar esta ventana.
                        return;
                    }
                }
                // Si ningun registro coincide con los datos ingresados, lo notifica con un mensaje y borra la contraseña.
                lblMensajes.Text = "La información no coincide.";
                txtContrasenia.Text = "";
            }
            // En caso de no existir ningun registro, se invita a registrarse amablemente.
            else
            {
                MessageBox.Show("No existen usuarios. Por favor registrese.", "Sin usuarios.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsuario.Text = "";
                txtContrasenia.Text = "";
                // Mandar a llamar el registro.
                AlternarInicioRegistro(false);
            }
        }
        private void Registrarse(XmlDocument escritor, string nombre, string usuario, string contrasenia)
        {
            // Crea un elemento contenedor (nodo) para el registro
            XmlNode nodoCuenta = escritor.CreateElement("perfil");

            // Funcion que ahorra trabajo. 
            void AgregarPropiedad(string etiqueta, string valor)
            {
                // Crea un elemento, le asigna el valor y lo agrega al contenedor de elementos.
                XmlElement hijo = escritor.CreateElement(etiqueta);
                hijo.InnerText = valor;
                nodoCuenta.AppendChild(hijo);
            }

            // Se registran los datos ingresados.
            AgregarPropiedad("nombre", nombre);
            AgregarPropiedad("usuario", usuario);
            AgregarPropiedad("contrasenia", contrasenia);

            // Se agrega el perfil al contenedor principal, el de los perfiles.
            escritor.DocumentElement.AppendChild(nodoCuenta);
            escritor.Save(Sistema.rutaUsuarios);

            // Accede al sistema.
            MessageBox.Show("Datos correctos. | Accediste al sistema.", "Acceso Permitido.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        //
        // Logica de apariencias.
        //
        private void AlternarInicioRegistro(bool deInicioToRegistro)
        {
            // Ajustar tamaños.
            // Si cambia a registro se deben modificar las propiedades (el mismo numero {1}),
            // si cambia a inicio de secion se deben contrarestar las modificaiones (el inverso del numero {-1}).
            int sentido = deInicioToRegistro ? 1 : -1;  
            grpInicioS.Height += 110 * sentido; // 130px entre 4 text y espacios, pero 20px menos del boton de recuperar contraseña
            // Desplazar los controles un sierto tamaño.
            grpInicioS.Location = new Point(grpInicioS.Location.X, grpInicioS.Location.Y - 50 * sentido ); // Hacia arriba (signo -) hay 50px a donde nos podemos mover.
            chkBoxRecordar.Location = new Point(chkBoxRecordar.Location.X, chkBoxRecordar.Location.Y + 20 * sentido); // Tomamos el espacio por debajo (signo +)
            btnAcceder.Location = new Point(btnAcceder.Location.X, btnAcceder.Location.Y + 20 * sentido); // correspondiente al boton de recuperar contraseña.
            txtUsuario.Location = new Point(txtUsuario.Location.X, txtUsuario.Location.Y + 35 * sentido); // 25px del alto de los txt y 12 px del espacio entre ellos.
            txtCorreo.Location = new Point(txtCorreo.Location.X, txtCorreo.Location.Y + 35 * 2 * sentido); // Esta en la primera posicion y debe llegar a la 3, con 2 txt por debajo.
            txtContrasenia.Location = new Point(txtContrasenia.Location.X, txtContrasenia.Location.Y + 35 * 2 * sentido); // Esta en la segunda posicion y debe llegar a la cuarta.
            iconoContrasenia.Location = new Point(iconoContrasenia.Location.X, iconoContrasenia.Location.Y + 35 * 2 * sentido);
            txtConfirmarContra.Location = new Point(txtConfirmarContra.Location.X, txtConfirmarContra.Location.Y + 35 * 3 * sentido);
            iconoConfirmarContra.Location = new Point(iconoConfirmarContra.Location.X, iconoConfirmarContra.Location.Y + 35 * 3 * sentido);
            txtEdad.Location = new Point(txtEdad.Location.X, txtEdad.Location.Y + 35 * 4 * sentido);
            // Mostrar controles extra.
            btnRecuperar.Visible = !deInicioToRegistro;
            txtNombre.Visible = deInicioToRegistro;
            txtCorreo.Visible = deInicioToRegistro;
            txtConfirmarContra.Visible = deInicioToRegistro;
            iconoConfirmarContra.Visible = deInicioToRegistro;
            txtEdad.Visible = deInicioToRegistro;
            // Cambiar textos.
            lblMensajes.Text = "";
            grpInicioS.Text = deInicioToRegistro ? "Registrarse en SIRETECH Poli" : "Iniciar Sesión en SIRETECH Poli";
            btnAcceder.Text = deInicioToRegistro ? "Registrarse" : "Iniciar Sesión";
            btnAlternar.Text = deInicioToRegistro ? "Iniciar Sesión" : "Registrarse";
        }
        private void btnAlternar_Click(object sender, EventArgs e)
        {
            // Transformamos al objeto que envia los datos en un control.
            Control boton = sender as Control;
            // Si el texto del control coincide, alterna a registro.
            if (boton.Text == "Registrarse") AlternarInicioRegistro(true);
            // Si no, alterna al inicio de secion.
            else AlternarInicioRegistro(false);
        }
        //
        // Logica de ventanas.
        //
        // Cargar ventana de "Acerca de" Solo minimizar la de registro.
        private void btnAcerca_Click(object sender, EventArgs e) { MessageBox.Show("Conocenos.", "Acerca de.", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        // Cargar ventana de "Politicas de Privacidad" Solo minimizar la de registro.
        private void btnPriva_Click(object sender, EventArgs e) { MessageBox.Show("Conoce nuestras politicas", "Politicas.", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        // Cargar ventana de "Recuperar contraseña" Solo minimizar la de registro.
        private void btnRecuperar_Click(object sender, EventArgs e) { MessageBox.Show("Enviaremos un correo a su direccion", "Recuperar.", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        //
        // Logica de utiilidades.
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
                caja.ForeColor = Color.FromArgb(0, 0, 0);
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
                caja.ForeColor = Color.FromArgb(99, 101, 105);
            }
        }
        private void QuitarPlaceHolderContrasenias(object Sender, string PlaceHolder)
        {
            TextBox caja = Sender as TextBox;
            if (caja.Text == PlaceHolder)
            {
                caja.PasswordChar = '*'; // Hace que aparescan asteriscos en ves de la contraseña.
                caja.Text = "";
                caja.ForeColor = Color.FromArgb(0, 0, 0);
            }
        }
        private void PonerPlaceHolderContrasenias(object Sender, string PlaceHolder)
        {
            TextBox caja = Sender as TextBox;
            if (caja.Text == "")
            {
                caja.PasswordChar = '\0'; // Hace que vuelvan a aparecer letras
                caja.Text = PlaceHolder;
                caja.ForeColor = Color.FromArgb(99, 101, 105);
            }
        }
        private void txtNombre_Enter(object sender, EventArgs e) { QuitarPlaceHolder(sender, "Nombre"); }
        private void txtNombre_Leave(object sender, EventArgs e) { PonerPlaceHolder(sender, "Nombre"); }
        private void txtUsuario_Enter(object sender, EventArgs e) { QuitarPlaceHolder(sender, "Usuario"); }
        private void txtUsuario_Leave(object sender, EventArgs e) { PonerPlaceHolder(sender, "Usuario"); }
        private void txtCorreo_Enter(object sender, EventArgs e) { QuitarPlaceHolder(sender, "Email"); } 
        private void txtCorreo_Leave(object sender, EventArgs e) { PonerPlaceHolder(sender, "Email"); }
        private void txtContrasenia_Enter(object sender, EventArgs e) { QuitarPlaceHolderContrasenias(sender, "Contraseña"); }
        private void txtContrasenia_Leave(object sender, EventArgs e) { PonerPlaceHolderContrasenias(sender, "Contraseña"); }
        private void txtConfirmarContra_Enter(object sender, EventArgs e) { QuitarPlaceHolderContrasenias(sender, "Confirmar Contraseña"); }
        private void txtConfirmarContra_Leave(object sender, EventArgs e) { PonerPlaceHolderContrasenias(sender, "Confirmar Contraseña"); }
        private void txtEdad_Enter(object sender, EventArgs e) { QuitarPlaceHolder(sender, "Edad"); }
        private void txtEdad_Leave(object sender, EventArgs e) { PonerPlaceHolder(sender, "Edad"); }

        private void AlternarVerContra(object Sender, object MarcoIcono, string PlaceHolder)
        {
            TextBox caja = Sender as TextBox;
            if (caja.Text == PlaceHolder) return;
            PictureBox icono = MarcoIcono as PictureBox;
            // Con una verificacion intercambia al caracter de contraseña correcto.
            bool Mostrar = caja.PasswordChar == '\0';
            caja.PasswordChar = Mostrar ? '*' : '\0';
            // Cambia de icono al correspondiente.
            icono.Image = Mostrar ? Properties.Resources.NoMostrarContra : Properties.Resources.MostrarContra;
        }
        private void iconoContrasenia_Click(object sender, EventArgs e) { AlternarVerContra(txtContrasenia, sender, "Contraseña"); }
        private void iconoConfirmarContra_Click(object sender, EventArgs e) { AlternarVerContra(txtConfirmarContra, sender, "Confirmar Contraseña"); }
    }
}
