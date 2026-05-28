using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PA4IM9_20262_Equipo2.Entidades
{
    //Dudas checar el apartado de "Perfil"
    [XmlRoot("subcuenta")]
    public class Subcuenta
    {
        [XmlElement("nombreSubcuenta")]
        public string NombreSubcuenta { get; set; }
        [XmlElement("monto")]
        public double Monto { get; set; }
    }
    [XmlRoot("cuenta")]
    public class Cuenta
    {
        [XmlElement("nombreCuenta")]
        public string NombreCuenta { get; set; }
        [XmlElement("subCuentas")]
        public string[] Subcuentas { get; set; }
    }

    [XmlRoot("asiento")]
    public class Asiento
    {
        [XmlElement("fecha")]
        public DateTime Fecha { get; set; }
        [XmlElement("sumaCargos")]
        public double SumaCargos { get; set; }
        [XmlElement("sumaAbonos")]
        public double SumaAbonos { get; set; }
        [XmlElement("concepto")]
        public string Concepto { get; set; }
    }

}
