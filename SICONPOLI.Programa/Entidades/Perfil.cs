using PA4IM9_20262_Equipo2.Modulos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace PA4IM9_20262_Equipo2.Entidades
{
    // Fragmento que identifica al elemento padre como la DECLARACION que le sigue.
    [XmlRoot("perfil")]
    public class Perfil // Nesesario que sean publicos para poder convertir en un elemento xml.
    {
        // Fragmento que identifica algun elemento como la DECLARACION que le sigue.
        [XmlElement("id")]
        public string ID { get; set; } // Methodos nesesarios para convertir los objetos a elementos xml
        [XmlElement("rol")]
        public string Rol { get; set; }
        [XmlElement("fechaCreacion")]
        public DateTime FechaCreacion { get; set; } 
        [XmlElement("usuario")]
        public string Usuario { get; set; }
        [XmlElement("correo")]
        public string Correo { get; set; }
        [XmlElement("contrasenia")]
        public string Contrasenia { get; set; }
        [XmlElement("nombre")]
        public string Nombre { get; set; } 
        [XmlElement("edad")]
        public int Edad { get; set; }

        public Perfil() { } // Constructor vacio.
    }
}
