using PA4IM9_20262_Equipo2.Entidades;
using PA4IM9_20262_Equipo2.Modulos;
using PA4IM9_20262_Equipo2.Vistas.Panel_Principal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

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

            Sistema.IniciarArchivos();
            RecordarUsuario();
        }
        private void RecordarUsuario()
        {
            // Verifica si el archivo de usuarios existe.
            Sistema.VerificarArchivo(Sistema.rutaUsuarios, Sistema.raizUsuarios);
            XmlDocument lector = new XmlDocument(); // Crea el controlador de archivos xml.
            lector.Load(Sistema.rutaUsuarios); // Carga el archivo de usuarios
            if (!ExistenUsuariosRegistrados(lector)) return; // Aprovechando la carga detecta si existen usuarios registrados.

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
        private bool ExistenUsuariosRegistrados(XmlDocument lector)
        {
            // Crea una lista de elementos xml con los elementos de nombre perfil.
            XmlNodeList perfiles = lector.DocumentElement.SelectNodes("perfil");
            // Si su conteo es 0 (no hay usuarios) envia al panel de registro.
            if (perfiles.Count == 0)
            {
                AlternarInicioRegistro(true); // Envia a la pantalla de registro.
                return false;
            }
            return true;
        }

        public void RecomendarActivo()
        {
            // Sacamos los datos del perfil activo y los ponemos en los campos.
            txtContrasenia.Text = Sistema.PerfilActivo.Contrasenia;
            txtUsuario.Text = Sistema.PerfilActivo.Usuario;
            chkBoxRecordar.Checked = true;
        }

        //
        // Logica de logueo.
        //
        private void btnAcceder_Click(object sender, EventArgs e)
        {
            // Verifica que SOLO los datos en los campos sean adecuados.
            if (!CamposCorrectos()) return; // Si estan vacíos notifica con un texto y termina el proseso.
            lblMensajes.Text = ""; // Limpia el mensaje.

            Sistema.VerificarArchivo(Sistema.rutaUsuarios, Sistema.raizUsuarios); // Verifica la existencia del archivo
            // Crea el controlador de archivos xml y carga el documento en la ruta de usuarios.
            XmlDocument documento = new XmlDocument();
            documento.Load(Sistema.rutaUsuarios);

            // Dependiendo del contenido en el boton enviara a inicios o registros de secion.
            if (btnAcceder.Text == "Iniciar Sesión") IniciarSesion(documento, txtUsuario.Text, txtContrasenia.Text);
            else if (btnAcceder.Text == "Registrarse") Registrarse(documento);
        }
        private void IniciarSesion(XmlDocument lector, string usuario, string contrasenia)
        {
            // Si en el elemento raiz del archivo existen registros:
            if (ExistenUsuariosRegistrados(lector))
            {
                // Recorrera cada registro.
                foreach (XmlElement elemento in lector.DocumentElement.ChildNodes)
                {
                    // Verificara si los datos ingresados coinciden con los datos del registro.
                    if (elemento["usuario"].InnerText == usuario && elemento["contrasenia"].InnerText == contrasenia)
                    {
                        // Logica para manejar correctamente 
                        VerificarRecordado(lector, elemento);
                        // Mandar a llamar al menu principal.
                        AbrirMenuPrincipal();
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
                // Notifica con una ventana que no existen usuarios.
                MessageBox.Show("No existen usuarios. Por favor registrese.", "Sin usuarios.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PonerPlaceHolder(txtUsuario, "Usuario"); // Limpia el campo.
                PonerPlaceHolder(txtContrasenia, "Contraseña"); // Limpia el campo.
            }
        }
        private void Registrarse(XmlDocument escritor)
        {
            // Crea un objeto para el perfil.
            Perfil nuevoPerfil = new Perfil();

            // Se asignan los datos fundamentales.
            nuevoPerfil.FechaCreacion = DateTime.Now;
            nuevoPerfil.ID = Sistema.GenerarID();
            // Se registran los datos ingresados.
            nuevoPerfil.Nombre = txtNombre.Text;
            nuevoPerfil.Usuario = txtUsuario.Text;
            nuevoPerfil.Correo = txtCorreo.Text;
            nuevoPerfil.Contrasenia = txtContrasenia.Text;
            nuevoPerfil.Edad = int.Parse(txtEdad.Text);
            // Dinamicamente asigna un Rol adecuado.
            nuevoPerfil.Rol = nuevoPerfil.ID == "1001" ? Sistema.Roles[0] : nuevoPerfil.Edad > 17 ? Sistema.Roles[2] : Sistema.RolPredefinido;
            // Cargamos el perfil nuevo en la memoria del programa para las sesiones activas.
            Sistema.CargarPerfilMemoria(nuevoPerfil);

            // Creamos un elemento Xml llenandolo con los datos del perfil antes llenado.
            XmlElement elementoPerfil = ConvertidorXml.ObjetoToElemento(escritor, nuevoPerfil);

            // Si esta marcada la casilla para recordar
            if (chkBoxRecordar.Checked == true) elementoPerfil.Attributes.Append(escritor.CreateAttribute("recordar"));

            // Se agrega el perfil al contenedor principal, el de los perfiles.
            escritor.DocumentElement.AppendChild(elementoPerfil);
            escritor.Save(Sistema.rutaUsuarios); // Guardar Cambios

            // Accede al sistema.
            AbrirMenuPrincipal();
        }
        private void VerificarRecordado(XmlDocument escritor, XmlElement elemento)
        {
            bool tieneRecordado = elemento.HasAttribute("recordado");
            bool aRecordar = chkBoxRecordar.Checked;

            // Revisamos si ya cuenta con el atributo recordar (no contenido en la clase perfil).
            // Si tiene el atributo primero devemos quitarselo y luego guardar el perfil.
            if (tieneRecordado)
            {
                // Se elimina forsosamente el atributo del elemento Xml.
                // De sus atributos elimina el atributo de nombre recordado.
                elemento.Attributes.RemoveNamedItem("recordado");
                // Si ya no se desea recordar se guardan los cambios, si aun se desea recordar no se DEBE guardar nada.
                if (!aRecordar) escritor.Save(Sistema.rutaUsuarios);

                // Transformamos el elemento xml a un objeto de tipo perfil.
                Perfil PerfilLogueado = ConvertidorXml.ElementoToObjeto<Perfil>(elemento);
                // Ese perfil coincidente lo guardamos en la memoria del programa.
                Sistema.CargarPerfilMemoria(PerfilLogueado);
            }
            else // Si no tiene el atributo solamente lo guardamos en memoria.
            {
                // Lo mismo que en las lineas de arriba.
                Perfil PerfilLogueado = ConvertidorXml.ElementoToObjeto<Perfil>(elemento);
                Sistema.CargarPerfilMemoria(PerfilLogueado);

                if (aRecordar) // Si se debe recordar.
                {
                    // Creamos y agregamos el atributo para recordar el elemento.
                    elemento.Attributes.Append(escritor.CreateAttribute("recordado")); 
                    escritor.Save(Sistema.rutaUsuarios); // Guardamos los cambios
                }
            }
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
            grpInicioS.Location = new Point(grpInicioS.Location.X, grpInicioS.Location.Y - 50 * sentido); // Hacia arriba (signo -) hay 50px a donde nos podemos mover.
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
        private void AbrirMenuPrincipal()
        {
            MenuPrincipal ventana = new MenuPrincipal(); // Creamos la ventana del panel principal.
            ventana.Show(); // la mostramos.
            this.Hide(); // Ocultamos esta.
        }
        // Cargar ventana de "Acerca de" Solo minimizar la de registro.
        private void btnAcerca_Click(object sender, EventArgs e) { MessageBox.Show("Conocenos.", "Acerca de.", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        // Cargar ventana de "Politicas de Privacidad" Solo minimizar la de registro.
        private void btnPriva_Click(object sender, EventArgs e) { MessageBox.Show("Conoce nuestras politicas", "Politicas.", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        // Cargar ventana de "Recuperar contraseña".
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
                // Caracter vacio.
                caja.PasswordChar = '\0'; // Hace que vuelvan a aparecer letras.
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
        
        //
        // Logica de Validacion.
        //
        private bool CamposCorrectos()
        {
            // Si los campos de inicio de secion estan vacios (llenos con su placeholder) o si los campos de registro estan activos y vacios (igual con su placeholder).
            if (txtUsuario.Text == "Usuario" || txtContrasenia.Text == "Contraseña" || (txtNombre.Visible == true && (txtNombre.Text == "Nombre" || txtCorreo.Text == "Email" || txtConfirmarContra.Text == "Confirmar Contraseña" || txtEdad.Text == "Edad")))
            {
                lblMensajes.Text = "Campos vacios";
                return false; // Entonces faltaran datos y se notificara.
            }
            // En caso de que esten llenos los campos pero no coincidan las contraseñas,
            else if (txtContrasenia.Text != txtConfirmarContra.Text && txtConfirmarContra.Visible) 
            {
                lblMensajes.Text = "Las contraseñas no coinciden."; // Indica que no son iguales las contraseñas.
                txtConfirmarContra.Focus(); // Manda a corregir la contraseña.
                return false;
            }
            else if (txtEdad.Visible)
            {
                int edad = int.Parse(txtEdad.Text);
                if (edad < 0 || edad >= 120)
                {
                    lblMensajes.Text = "Rango de edad no valido."; // Indica un rango de edad no valido
                    txtEdad.Focus(); // Manda a corregir
                    return false; 
                } else if (edad < 10)
                {
                    lblMensajes.Text = "Solo mayores de 10 años.";
                    txtEdad.Focus();
                    return false;
                }
            }
            return true;
        }
        private bool CorreoValido(string cadena)
        {
            // Expresion regular para que se asemeje a un correo electronico.
            string expresionRegular = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            // Si coincide la expresion con el texto, pasa a la siguiente verificacion.
            if (Regex.IsMatch(cadena, expresionRegular))
            {
                // Reemplaza los elementos que coincidan con la expresion regular por nada. Si al final de esa operacion no sobro ningun caracter, es un correo.
                if (Regex.Replace(cadena, expresionRegular, String.Empty).Length == 0) return true;
                // Si sobra algo, tan solo es un troso de correo con mas cosas.
                else return false;
            }
            else return false; // Si no coincide la exprecion no es un correo. 
        }
        private bool ConEspacios(string cadena)
        {
            // Indica que coincide con uno o mas caracteres sin espacio.
            string expresionRegular = @"^\S+$";
            if (Regex.IsMatch(cadena, expresionRegular)) return false; 
            else return true;
        }

        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            if (txtNombre.Text == "Nombre") lblMensajes.Text = "Falta ingresar el nombre.";
        }
        private void txtUsuario_Validating(object sender, CancelEventArgs e)
        {
            if (txtUsuario.Text == "Usuario") lblMensajes.Text = "Falta ingresar el usuario";
            else if (ConEspacios(txtUsuario.Text))
            {
                lblMensajes.Text = "El usuario no debe contener espacios.";
                txtUsuario.Focus();
            }
        }
        private void txtCorreo_Validating(object sender, CancelEventArgs e)
        {
            if (txtCorreo.Text == "Email") lblMensajes.Text = "Falta ingresar el correo.";
            else if (!CorreoValido(txtCorreo.Text) && txtCorreo.Visible == true)
            {
                lblMensajes.Text = "El correo no es valido.";
                txtCorreo.Focus();
            }
        }
        private void txtContrasenia_Validating(object sender, CancelEventArgs e)
        {
            if (txtContrasenia.Text == "Contraseña") lblMensajes.Text = "Falta ingresar la contraseña.";
            else if (ConEspacios(txtContrasenia.Text))
            {
                lblMensajes.Text = "La contraseña no debe tener espacios.";
                txtContrasenia.Focus();
            }
            if (txtConfirmarContra.Text == txtContrasenia.Text && lblMensajes.Text == "Las contraseñas no coinciden.") lblMensajes.Text = ""; 
        }
        private void txtConfirmarContra_Validating(object sender, CancelEventArgs e)
        {
            if (txtConfirmarContra.Text == "Confirmar Contraseña") lblMensajes.Text = "Falta confirmar la contraseña.";
            else if (ConEspacios(txtConfirmarContra.Text))
            {
                lblMensajes.Text = "La contraseña no debe tener espacios.";
                txtConfirmarContra.Focus();
            }
            else if (txtConfirmarContra.Text != txtContrasenia.Text) lblMensajes.Text = "Las contraseñas no coinciden.";
        }
        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) e.Handled = false;
            else if (Char.IsControl(e.KeyChar)) e.Handled = false;
            else if (Char.IsSeparator(e.KeyChar)) e.Handled = false;
            else e.Handled = true;
        }

        private void txtEdad_Validating(object sender, CancelEventArgs e) { if (txtEdad.Text == "Edad") lblMensajes.Text = "Falta ingresar la edad."; }
    }
}