using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PA4IM9_20262_Equipo2.Modulos
{
    internal static class Sistema
    {
        public static string rutaEjecusion = AppDomain.CurrentDomain.BaseDirectory;
        public static string rutaUsuarios = Path.Combine(rutaEjecusion, "..", "..", "Datos", "Usuarios.xml");
        
        // Verificacion de la existencia de un archivo XML.
        public static void VerificarArchivo(string ruta, string nombreRaiz)
        {
            // Objeto que puede manejar archivos .xml.
            XmlDocument documento = new XmlDocument();

            // Intenta cargar el archivo contenido en la ruta especificada.
            try { documento.Load(ruta); } 
            // En caso de no poder cargar el archivo
            catch {
                // Verifica que exista el archivo, en caso contrario lo crea.
                if (!File.Exists(ruta)) File.Create(ruta);
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
                documento.Save(ruta);
                return;
            }
            // De manera contraria crea una declaracion xml y la agrega al principio del archivo.
            XmlDeclaration declaration = documento.CreateXmlDeclaration("1.0", "UTF-8", "");
            documento.InsertBefore(declaration, documento.FirstChild);

            // Guarda los cambios en el mismo archivo/ruta.
            documento.Save(ruta);
        }

        public static void CargarArchivos()
        {
            VerificarArchivo(rutaUsuarios, "usuarios");
        }
    }
}
