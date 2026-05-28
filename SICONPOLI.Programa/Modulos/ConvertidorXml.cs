using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace PA4IM9_20262_Equipo2.Modulos
{
    internal static class ConvertidorXml
    {
        // Funcion que retorna un XmlElement. "<>" indica funcion de tipo de dato especifico (sobre todo usado para sobrecargas).
        // Con la clave de c# "T" indicamos que sera cualquier tipo de dato despues especificado. La segunda T indica un objeto de tipo de dato especificado antes.
        public static XmlElement ObjetoToElemento<T>(XmlDocument Documento, T Objeto)
        {
            // Creamos el convertidor con la estructura de la clase.
            XmlSerializer Convertidor = new XmlSerializer(typeof(T));
            string fragmentoXml = string.Empty; // Cadena para guardar el elemento en texto.

            // Variable para ajustes de lectores XML para generar un archivo XML metadatos que generaran problemas.
            XmlWriterSettings settings = new XmlWriterSettings
            {
                OmitXmlDeclaration = true, // Omite declaraciones
                ConformanceLevel = ConformanceLevel.Document, // Cambia el nivel de alcance, nivel nesesario para el serializador.
                Indent = true // Identacion/sangria para que sea legible por humanos.
            };

            // Creamos la variable para espacios de nombre vacios para evitar otros metadatos.
            XmlSerializerNamespaces namespacesVacios = new XmlSerializerNamespaces();
            namespacesVacios.Add(string.Empty, string.Empty); // Agregamos los espacios vacios.

            // Serializamos el objeto en memoria
            using (StringWriter EscritorCadena = new StringWriter()) // Escritor en strings y no archivos.
            {
                using (XmlWriter escritorXml = XmlWriter.Create(EscritorCadena, settings)) // "Escritor" (ya que depende de otro escritor) Xml con configuracion dada por nosotros.
                {
                    Convertidor.Serialize(escritorXml, Objeto, namespacesVacios); // Con el escritor Xml se srializa en objeto sin declaraciones ni espacios de nombre.
                }
                fragmentoXml = EscritorCadena.ToString(); // Transforma el serial en texto.
            }

            XmlDocument documentoTemporal = new XmlDocument(); // Segundo controlador temporal para pasar el elemento.
            // Lo cargamos como un elemento Xml mediante el controlador.
            documentoTemporal.LoadXml(fragmentoXml);

            // Importamos el elemento raíz al documento para no generar problemas con el DocumentElement del archivo. (Por el XmlRoot de la clase).
            XmlNode nodoImportado = Documento.ImportNode(documentoTemporal.DocumentElement, true);

            // Damos el elemento transformado en XmlElement listo para AppendChild
            return (XmlElement)nodoImportado;
        }
        // Funcion que retorna un objeto despues especificado.
        public static T ElementoToObjeto<T>(XmlElement Elemento)
        {
            // Creamos el desconvertidor con la estructura del objeto especificado.
            XmlSerializer Desconvertidor = new XmlSerializer(typeof(T));
            // Creamos un lector de nodos (elemento con mas elementos dentro) que lee el elemento.
            using (XmlNodeReader Lector = new XmlNodeReader(Elemento))
            {
                // Damos el elemento desconvertido y transformado al objeto especificado.
                return (T)Desconvertidor.Deserialize(Lector);
            }
        }
    }
}
