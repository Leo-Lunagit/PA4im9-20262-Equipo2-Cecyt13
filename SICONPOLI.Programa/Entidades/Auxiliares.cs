using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PA4IM9_20262_Equipo2.Entidades
{
    public enum Acciones
    {
        Compra = 1,
        Pago = 2,
        Venta = 3,
        Cobro = 4,
    }

    public enum Cuentas
    {
        Bancos = 1,
        Almacen = 2,
        Clientes = 3,
        Proveedores = 4,
    }

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

    //
    // Libros mayores.
    //

    public class RenMayor
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

    [XmlRoot("mayor")]
    public class Mayor
    {
        [XmlAttribute("cuenta")]
        public string Cuenta { get; set; }
        [XmlAttribute("noTarjeta")]
        public string NoTargeta { get; set; }
        [XmlElement("titular")]
        public string Titular { get; set; }
        [XmlArray("movMayores")]
        [XmlArrayItem("renMayores")]
        public RenMayor[] RenMayores { get; set; }
    }

    // 
    // Targetas de almacen.
    //

    public class RenAlmacen
    {
        [XmlAttribute("folio")]
        public string Folio { get; set; }
        [XmlElement("fecha")]
        public string Fecha { get; set; }
        [XmlElement("factura")]
        public string Factura { get; set; }
        [XmlElement("movInventario")]
        public Movimiento MovInventario { get; set; }
        [XmlElement("Existencia")]
        public int Existencia { get; set; }
        [XmlElement("costo")]
        public int CostoUnitario { get; set; }
        [XmlElement("movValor")]
        public int CostoPromedio { get; set; }
        public Movimiento MovValor { get; set; }
        [XmlElement("montoSaldo")]
        public int MontoSaldo { get; set; }
    }

    [XmlRoot("almacen")]
    public class Almacen
    {
        [XmlAttribute("noTarjeta")]
        public string NoTarjeta { get; set; }
        [XmlElement("producto")]
        public string Producto { get; set; }
        [XmlElement("costoUnitario")]
        public int CostoUnitario { get; set; }
        [XmlArray("movAlmacen")]
        [XmlArrayItem("renAlmacen")]
        public RenAlmacen[] RenAlmacens { get; set; }
    }
}
