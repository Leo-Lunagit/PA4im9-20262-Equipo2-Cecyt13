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
        private void btnIniciarS_Click(object sender, EventArgs e)
        {
            // Verifica que SOLO los campos neseasarios No esten vacíos.
            if (txtUsuario.Text == "" || txtContrasenia.Text == "" || (txtNombre.Text == "" && txtNombre.Visible == true))
            {
                // Si estan vacíos notifica con un texto y termina el proseso.
                //lblMensajes.Text = "Campos vacios.";
                return;
            }
            // EN CASO DE QUE NO ESTEN VACÍOS.
            //lblMensajes.Text = ""; // Limpia el mensaje.

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
                // lblMensajes.Text = "La información no coincide.";
                txtContrasenia.Text = "";
            }
            // En caso de no existir ningun registro, se invita a registrarse amablemente.
            else
            {
                MessageBox.Show("No existen usuarios. Por favor registrese.", "Sin usuarios.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsuario.Text = "";
                txtContrasenia.Text = "";
                // Mandar a llamar el registro.
                AlternarInicioRegistro(50, false);
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
        // Logica de ventanas.
        //
        // Cargar ventana de "Acerca de" Solo minimizar la de registro.
        private void btnAcerca_Click(object sender, EventArgs e) { MessageBox.Show("Conocenos.", "Acerca de.", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        // Cargar ventana de "Politicas de Privacidad" Solo minimizar la de registro.
        private void btnPriva_Click(object sender, EventArgs e) { MessageBox.Show("Conoce nuestras politicas", "Politicas.", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        // Cargar ventana de "Recuperar contraseña" Solo minimizar la de registro.
        private void btnRecuperar_Click(object sender, EventArgs e) { MessageBox.Show("Enviaremos un correo a su direccion", "Recuperar.", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        //
        // Logica de apariencias.
        //
        private void AlternarInicioRegistro(int desplazamiento, bool inicio)
        {
            // Ajustar tamaños.
            int ajuste = !inicio ? -20 : 20; // 20px del boton para recuperar la contraseña.
            this.MaximumSize = new Size(this.Width, this.Height + desplazamiento + ajuste);
            this.MinimumSize = new Size(this.Width, this.Height + desplazamiento + ajuste);
            grpInicioS.Height += desplazamiento + ajuste;
            // Desplazar los controles un sierto tamaño.
            txtUsuario.Location = new Point(txtUsuario.Location.X, txtUsuario.Location.Y + desplazamiento);
            txtContrasenia.Location = new Point(txtContrasenia.Location.X, txtContrasenia.Location.Y + desplazamiento);
            chkBoxRecordar.Location = new Point(chkBoxRecordar.Location.X, chkBoxRecordar.Location.Y + desplazamiento);
            btnAcceder.Location = new Point(btnAcceder.Location.X, btnAcceder.Location.Y + desplazamiento);
            btnRecuperar.Location = new Point(btnRecuperar.Location.X, btnRecuperar.Location.Y + desplazamiento);
            // Mostrar controles extra.
            btnRecuperar.Visible = inicio;
            txtNombre.Visible = !inicio;
            // Cambiar textos.
            // lblMensajes.Text = "";
            grpInicioS.Text = inicio ? "Iniciar Sesión en SICONPOLI" : "Registrarse en SICONPOLI";
            btnAcceder.Text = inicio ? "Iniciar Sesión" : "Registrarse";
            btnRegistrar.Text = inicio ? "Registrarse" : "Iniciar Sesión";
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

        }
    }
}
