using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PA4IM9_20262_Equipo2.Entidades
{
    // Para poderse usar y asignar en el saldo del movimiento usar
    // ((Saldos)1).ToString() : el 1 puede cambiar por el 2
    public enum Saldos
    {
        Deudor = 1,
        Acredor = 2
    }

    public class Movimiento
    {
        [XmlAttribute("saldo")]
        public string Saldo { get; set; }
        [XmlElement("monto")]
        public int Monto { get; set; }
    } 

    public class RenAuxiliar
    {
        [XmlAttribute("folio")]
        public string Folio { get; set; }
        [XmlElement("fecha")]
        public string Fecha { get; set; }
        [XmlElement("factura")]
        public string Factura { get; set; }
        [XmlElement("concepto")]
        public string Concepto { get; set; }
        [XmlElement("movimiento")]
        public Movimiento Movimiento { get; set; }
        [XmlElement("montoSaldo")]
        public int MontoSaldo { get; set; }
    }

    [XmlRoot("auxiliar")]
    public class MayorAuxiliar
    {
        [XmlAttribute("cuenta")]
        public string Cuenta { get; set; }
        [XmlAttribute("noTarjeta")]
        public string NoTargeta { get; set; }
        [XmlElement("titular")]
        public string Titular { get; set; }
        [XmlArray("movAuxiliares")]
        [XmlArrayItem("renAuxiliar")]
        public RenAuxiliar[] RenAuxiliares { get; set; }
    }
}
