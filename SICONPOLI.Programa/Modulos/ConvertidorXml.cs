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
        // Su propio controlador de archivos XML para escribir.
        private static XmlDocument Escritor = new XmlDocument();
        // Funcion que retorna un XmlElement. "<>" indica funcion de tipo de dato especifico (sobre todo usado para sobrecargas).
        // Con la clave de c# "T" indicamos que sera cualquier tipo de dato despues especificado. La segunda T indica un objeto de tipo de dato especificado antes.
        public static XmlElement ObjetoToElemento<T>(T Objeto)
        {
            // Creamos un elemento con la estructura de la clase.
            XmlElement elemento = Escritor.CreateElement(typeof(T).Name);
            // Creamos el convertidor con la estructura de la clase.
            XmlSerializer Convertidor = new XmlSerializer(typeof(T));
            // Tan solo para el fragmento de codigo para despues autoliberar los archivos y memoria.
            // Creamos un escrtitor con la ruta en segida (AppendChild) del elemento (Navigator).
            using (XmlWriter Escritor = elemento.CreateNavigator().AppendChild())
            {
                // Serializamos (convertimos a elemento) el objeto mediante el escritor.
                Convertidor.Serialize(Escritor, Objeto);
            }
            // Damos el elemento transformado en XmlElement
            return (XmlElement)elemento.FirstChild;
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
