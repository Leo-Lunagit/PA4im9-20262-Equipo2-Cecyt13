using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PA4IM9_20262_Equipo2.Entidades
{
    //Dudas checar el apartado de "Perfil"
    public class Subcuenta
    {
        [XmlElement("nombreSubcuenta")]
        public string NombreSubcuenta { get; set; }
        [XmlElement("monto")]
        public int Monto { get; set; }
    }
    public class Cuenta
    {
        [XmlElement("nombreCuenta")]
        public string NombreCuenta { get; set; }
        [XmlArray("subcuentas")] // Indicamos un elemento contenedor.
        [XmlArrayItem("subcuenta")] // Indicamos el elemento por cada contenido del array.
        public Subcuenta[] Subcuentas { get; set; }
        [XmlElement("monto")]
        public int Monto { get; set; }
    }
    // Unicamente este tendra la etiqueta root, solo este sera el elemento padre, no puede aver mas de uno.
    // Para cada clase se le especifica la etiqueta contenedora (su padre) con XmlElement o XmlArray.
    [XmlRoot("asiento")] 
    public class Asiento
    {
        [XmlAttribute("noAsiento")] // Indica que no sera un atributo, si no un metadato.
        public int NoAsiento { get; set; }
        [XmlElement("fecha")]
        public DateTime Fecha { get; set; }
        [XmlArray("cargos")]
        [XmlArrayItem("cuenta")]
        public Cuenta[] Cargos { get; set; }
        [XmlArray("abonos")]
        [XmlArrayItem("cuenta")]
        public Cuenta[] Abonos { get; set; }
        [XmlElement("sumaCargos")]
        public int SumaCargos { get; set; }
        [XmlElement("sumaAbonos")]
        public int SumaAbonos { get; set; }
        [XmlElement("concepto")]
        public string Concepto { get; set; }
    }
}
