using PA4IM9_20262_Equipo2.Entidades;
using PA4IM9_20262_Equipo2.Vistas.CamposSubCuentas;
using PA4IM9_20262_Equipo2.Vistas.FormulariosRegistros;
using PA4IM9_20262_Equipo2.Vistas.PanelVentas;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace PA4IM9_20262_Equipo2.Modulos
{
    internal static class Rutas
    {
        // Mediante esos codigos se obtiene la ruta de archivos donde se esta ejecutando el programa.
        private static string Ejecusion = AppDomain.CurrentDomain.BaseDirectory;
        // Obtiene la carpeta padre de la carpeta padre de la carpeta donde se ejecuta el programa.
        private static string Proyecto = Directory.GetParent(Directory.GetParent(Directory.GetParent(Ejecusion).ToString()).ToString()).ToString();
        // Anida la carpeta 'Datos' dentro de la carpeta del proyecto.
        public static string Datos = Path.Combine(Proyecto, "Datos");
        public static string Usuarios = Path.Combine(Datos, "Usuarios.xml");
        public static string Configuracion = Path.Combine(Datos, "Configuracion.xml");
        public static string Compras = Path.Combine(Datos, "Compras.xml");
        public static string Ventas = Path.Combine(Datos, "Ventas.xml");
        public static string Proveedores = Path.Combine(Datos, "Proveedores.xml");
        public static string Clientes = Path.Combine(Datos, "Clientes.xml");
        public static string Productos = Path.Combine(Datos, "Productos.xml");
        public static string MayoresProveedores = Path.Combine(Datos, "MayoresProveedores.xml");
        public static string MayoresClientes = Path.Combine(Datos, "MayoresClientes.xml");
        public static string Almacen = Path.Combine(Datos, "Almacen.xml");
    }

    internal static class Raices // Nombre de los elementos raices de los archivos Xml.
    {
        public static string Usuarios = "usuarios";
        public static string Configuracion = "configuracion";
        public static string PadreUsuarios = "usuariosActivos";
        public static string Compras = "compras";
        public static string Ventas = "ventas";
        public static string Proveedores = "proveedores";
        public static string Clientes = "clientes";
        public static string Productos = "productos";
        public static string MayoresProveedores = "MayoresProveedores";
        public static string MayoresClientes = "MayoresClientes";
        public static string Almacen = "almacen";
    }

    public static class MEMORIA
    {
        public static PaqueteAlmacen[] Productos = new PaqueteAlmacen[0];
        public static PaqueteTitular[] Clientes = new PaqueteTitular[0];
        public static PaqueteTitular[] Proveedores = new PaqueteTitular[0];

        public static void CargarMemorias()
        {
            Sistema.VerificarArchivo(Rutas.Productos, Raices.Productos);
            Sistema.VerificarArchivo(Rutas.Proveedores, Raices.Proveedores);
            Sistema.VerificarArchivo(Rutas.Clientes, Raices.Clientes);
            XmlDocument lector = new XmlDocument();

            lector.Load(Rutas.Productos);
            foreach (XmlElement registro in lector.DocumentElement.ChildNodes)
                Productos = Productos.Append(ConvertidorXml.ElementoToObjeto<PaqueteAlmacen>(registro)).ToArray();

            lector.Load(Rutas.Clientes);
            foreach (XmlElement registro in lector.DocumentElement.ChildNodes)
                Clientes = Clientes.Append(ConvertidorXml.ElementoToObjeto<PaqueteTitular>(registro)).ToArray();

            lector.Load(Rutas.Proveedores);
            foreach (XmlElement registro in lector.DocumentElement.ChildNodes)
                Proveedores = Proveedores.Append(ConvertidorXml.ElementoToObjeto<PaqueteTitular>(registro)).ToArray();
        }
    }

    internal static class Sistema
    {
        // Variables para guardar los perfiles logueados.
        public static Perfil[] PerfilesLogueados;
        public static Perfil PerfilActivo;
        // Variables de informacion util para los perfiles.
        public static string[] Roles = { "administrador", "colaborador", "cliente" };
        public static string RolPredefinido = Roles[2];
        public static string banderaRecordar = "recordado";
        //
        public static decimal PorcentajeUtilida = .50m;

        // Verificacion de la existencia de un archivo XML.
        public static void VerificarArchivo(string ruta, string nombreRaiz)
        {
            // Objeto que puede manejar archivos .xml.
            XmlDocument documento = new XmlDocument();

            // Intenta cargar el archivo contenido en la ruta especificada.
            try { documento.Load(ruta); }
            // En caso de no poder cargar el archivo
            catch {
                // Si existe obtenemos la ruta de la carpeta para poder evaluarla.
                string directorio = Directory.GetParent(ruta)?.FullName;
                // Si no existe la ruta padre del elemento, crea ese directorio (carpeta).
                if (!Directory.Exists(directorio)) Directory.CreateDirectory(directorio);
                // Si no existia el archivo, hay que llenarlo, si ya existia entonces estaba vasio, hay que llenarlo.
                // Se crea un nodo (elemento con mas elementos dentro) con el manejador de archivos xml.
                XmlNode elementoRaiz = documento.CreateElement(nombreRaiz);
                // Se carga el nodo en el archivo que teniamos en el manejador.
                documento.AppendChild(elementoRaiz);
            }

            // Si como primer elemento tiene una delcaracion xml ya no nesesita nada mas
            if (documento.FirstChild is XmlDeclaration)
            {
                // Guarda los cambios en el mismo archivo/ruta.
                // Si no existe el archivo lo crea.
                documento.Save(ruta);
                return;
            }
            // De manera contraria crea una declaracion xml y la agrega al principio del archivo.
            XmlDeclaration declaration = documento.CreateXmlDeclaration("1.0", "UTF-8", "");
            documento.InsertBefore(declaration, documento.FirstChild);

            // Guarda los cambios en el mismo archivo/ruta.
            documento.Save(ruta);
        }

        public static void IniciarArchivos()
        {
            VerificarArchivo(Rutas.Usuarios, Raices.Usuarios);
            VerificarArchivo(Rutas.Configuracion, Raices.Configuracion);
            VerificarArchivo(Rutas.Compras, Raices.Compras);
            VerificarArchivo(Rutas.Ventas, Raices.Ventas);
            VerificarArchivo(Rutas.Proveedores, Raices.Proveedores);
            VerificarArchivo(Rutas.Clientes, Raices.Clientes);
            VerificarArchivo(Rutas.Productos, Raices.Productos);
            VerificarArchivo(Rutas.MayoresProveedores, Raices.MayoresProveedores);
            VerificarArchivo(Rutas.MayoresClientes, Raices.MayoresClientes);
            VerificarArchivo(Rutas.Almacen, Raices.Almacen);
            MEMORIA.CargarMemorias();
        }

        public static string GenerarID(string Ruta, string Raiz, int Cifras)
        {
            VerificarArchivo(Ruta, Raiz);
            XmlDocument lector = new XmlDocument();
            lector.Load(Ruta);        
            // El numero de perfiles mas 1, asegurandose que minimo tenga 3 cifras aunque con 0 a la izquierda (:D3).
            return "1" + (lector.DocumentElement.ChildNodes.Count + 1).ToString($"D{Cifras}"); 
        }

        public static void GuardarPerfil(XmlElement usuario)
        {
            VerificarArchivo(Rutas.Configuracion, Raices.Configuracion);
            XmlDocument config = new XmlDocument();
            config.Load(Rutas.Configuracion);

            XmlNode perfiles = config.DocumentElement[Raices.PadreUsuarios];
            if (perfiles == null)
            {
                XmlElement usuariosActivos = config.CreateElement(Raices.PadreUsuarios);
                config.DocumentElement.AppendChild(usuariosActivos);
            }

            XmlNode coincidencia = config.DocumentElement.SelectSingleNode($"//perfil[@id='{usuario.Attributes["id"].Value}']");
            if (coincidencia == null)
            {
                // Guarda el perfil junto a los perfiles antes guardados.
                XmlNode importado = config.ImportNode(usuario, true);
                config.DocumentElement[Raices.PadreUsuarios].AppendChild(importado);
            }

            config.Save(Rutas.Configuracion);
        }

        public static void ActualizarPerfilActivo(Perfil PerfilLogueado)
        {
            // Si no hay pefiles lo guarda directo.
            if (PerfilesLogueados == null || PerfilesLogueados.Length == 0)
                // Es nesesario crear un nuevo arreglo y luego reemplazar el actual por el creado.
                PerfilesLogueados = new Perfil[] { PerfilLogueado };
            // Si hay perfiles. Y no existe ningun elemento donde coincidan los ides lo guarda.
            else if (!PerfilesLogueados.Any(perfil => perfil.ID == PerfilLogueado.ID))
                // Guarda el perfil junto a los perfiles antes logueados.
                PerfilesLogueados = PerfilesLogueados.Append(PerfilLogueado).ToArray();

            // Siempre guarda o sobreescibe el perfil logueado como el perfil actual.
            PerfilActivo = PerfilLogueado;
        }

        public static void LimpiarRecordado()
        {
            VerificarArchivo(Rutas.Usuarios, Raices.Usuarios);
            XmlDocument escritor = new XmlDocument();
            escritor.Load(Rutas.Usuarios);

            // Buscamos un elemento con el atributo recordar
            XmlNode perfilRecordar = escritor.DocumentElement.SelectSingleNode("perfil[@recordado]");
            // Si existe el elemento buscado:
            if (perfilRecordar != null)
            {
                // Eliminamos el atributo del elemento y guardamos el cambio.
                perfilRecordar.Attributes.RemoveNamedItem("recordado");
                escritor.Save(Rutas.Usuarios);
            }
        }

        public static void IndexarFormulario(object Suscriptor, Panel Contenedor, object ObjFormHijo, EnlaceEventos[] enlaces) 
        {
            // Tranformamos el objeto de formulario en un formulario.
            Form FormHijo = ObjFormHijo as Form;

            // Si el contendero tiene elementos, los elimina
            if (Contenedor.Controls.Count > 0)
                Contenedor.Controls.RemoveAt(0);

            SuscriptorEventos.VincularEventos(enlaces, Suscriptor, ObjFormHijo);
            FormHijo.TopLevel = false; // Indica que no es un formulario de alto nivel, si no subordinado.
            FormHijo.Dock = DockStyle.Fill; // Indica que ocupe todo el espacio.   
            Contenedor.Controls.Add(FormHijo); // Agrega el control al contenedor.
            Contenedor.Tag = FormHijo;
            FormHijo.Show(); // Muestra el panel.
        }

        public static void IndexarControles(object Suscriptor, Panel Contenedor, object ObjControles, EnlaceEventos[] enlaces, DockStyle Dock)
        {
            // Tranformamos el objeto del UserControls en un Contol normal.
            Control Controles = ObjControles as Control;

            SuscriptorEventos.VincularEventos(enlaces, Suscriptor, Controles);
            Controles.Dock = Dock;
            Contenedor.Controls.Add(Controles);
        }
        public static void IndexarCampos(Formulario Suscriber, Panel Contenedor, Campos Controles, Cuentas Cuenta)
        {
            // Lo dispone en la parte superior (automaticamente lo coloca arriba de su hermano.)
            Controles.Dock = DockStyle.Top;
            Controles.Cuenta = Cuenta;

            // Vincula los eventos, hace que le notifique en cuanto ocurra dicho evento para que el escucha ejecute la funcion.
            Controles.CambiarCostoTotal += Suscriber.CambiarSumaTotal;
            Controles.LlamarAutoEliminacion += Suscriber.ElinarCampos;

            Contenedor.Controls.Add(Controles);
        }
    }
}
