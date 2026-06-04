using PA4IM9_20262_Equipo2.Entidades;
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
    internal static class Sistema
    {
        // Mediante esos codigos se obtiene la ruta de archivos donde se esta ejecutando el programa.
        public static string rutaEjecusion = AppDomain.CurrentDomain.BaseDirectory;
        // Fusiona la ruta de ejecucion con una ruta nueva, regresa dos carpetas a la carpeta donde tenemos todo el codigo, se dirije a la carpeta de "Datos" y al arhivo.
        public static string rutaUsuarios = Path.Combine(rutaEjecusion, "..", "..", "Datos", "Usuarios.xml");
        public static string rutaConfiguracion = Path.Combine(rutaEjecusion, "..", "..", "Datos", "Configuracion.xml");
        public static string rutaCompras = Path.Combine(rutaEjecusion, "..", "..", "Datos", "Compras.xml");
        public static string rutaVentas = Path.Combine(rutaEjecusion, "..", "..", "Datos", "Ventas.xml");
        public static string raizUsuarios = "usuarios"; // Elemento raiz del archivo.
        public static string raizConfiguracion = "configuracion"; // Elemento raiz del archivo.
        public static string raizCompras = "compras"; // Elemento raiz del archivo.
        public static string raizVentas = "ventas"; // Elemento raiz del archivo.
        public static string[] Roles = { "administrador", "colaborador", "cliente" };
        public static string RolPredefinido = Roles[2];
        // Variables para guardar los perfiles logueados.
        public static Perfil[] PerfilesLogueados;
        public static Perfil PerfilActivo;
        public static string banderaRecordar = "recordado";
        
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
            VerificarArchivo(rutaUsuarios, raizUsuarios);
            VerificarArchivo(rutaCompras, raizCompras);
            VerificarArchivo(rutaVentas, raizVentas);
        }

        public static string GenerarID()
        {
            XmlDocument lector = new XmlDocument();
            lector.Load(rutaUsuarios);
            // El numero de perfiles mas 1, asegurandose que minimo tenga 3 cifras aunque con 0 a la izquierda (:D3).
            return $"1{(lector.DocumentElement.ChildNodes.Count + 1):D3}"; 
        }
        
        public static void GuardarPerfil(XmlElement usuario) 
        {
            string PadreUsuarios = "usuariosActivos";
            VerificarArchivo(rutaConfiguracion, raizConfiguracion);
            XmlDocument config = new XmlDocument();
            config.Load(rutaConfiguracion);
            
            XmlNode perfiles = config.DocumentElement[PadreUsuarios];
            if (perfiles == null)
            {
                XmlElement usuariosActivos = config.CreateElement(PadreUsuarios);
                config.DocumentElement.AppendChild(usuariosActivos);
            }

            XmlNode coincidencia = config.DocumentElement.SelectSingleNode($"//perfil[@id='{usuario.Attributes["id"].Value}']");
            if (coincidencia == null)
            {
                // Guarda el perfil junto a los perfiles antes guardados.
                XmlNode importado = config.ImportNode(usuario, true);
                config.DocumentElement[PadreUsuarios].AppendChild(importado);
            }
                
            config.Save(rutaConfiguracion);
        }

        public static void CargarPerfil(Perfil PerfilLogueado)
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
        
        public static void ManejarRecordado(XmlDocument escritor, XmlElement elemento, bool aRecordar)
        {
            bool tieneRecordado = elemento.HasAttribute(banderaRecordar);

            // Revisamos si ya cuenta con el atributo recordar (no contenido en la clase perfil).
            // Si tiene el atributo primero devemos quitarselo y luego guardar el perfil.
            if (tieneRecordado)
            {
                // Se elimina forsosamente el atributo del elemento Xml.
                // De sus atributos elimina el atributo de nombre recordado.
                elemento.Attributes.RemoveNamedItem(banderaRecordar);
                // Si ya no se desea recordar se guardan los cambios, si aun se desea recordar no se DEBE guardar nada.
                if (!aRecordar) escritor.Save(Sistema.rutaUsuarios);

                // Transformamos el elemento xml a un objeto de tipo perfil.
                Perfil PerfilLogueado = ConvertidorXml.ElementoToObjeto<Perfil>(elemento);
                // Ese perfil coincidente lo guardamos en la memoria del programa.
                Sistema.CargarPerfil(PerfilLogueado);
            }
            else // Si no tiene el atributo solamente lo guardamos en memoria.
            {
                // Lo mismo que en las lineas de arriba.
                Perfil PerfilLogueado = ConvertidorXml.ElementoToObjeto<Perfil>(elemento);
                Sistema.CargarPerfil(PerfilLogueado);

                if (aRecordar) // Si se debe recordar.
                {
                    // Creamos y agregamos el atributo para recordar el elemento.
                    elemento.Attributes.Append(escritor.CreateAttribute(banderaRecordar)); 
                    escritor.Save(Sistema.rutaUsuarios); // Guardamos los cambios
                }
            }
        }
    }
}
