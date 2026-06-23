using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PA4IM9_20262_Equipo2.Entidades
{
    [XmlRoot("paqueteTitular")]
    public class PaqueteTitular
    {
        [XmlAttribute("noTarjeta")]
        public string NoTarjeta;
        [XmlElement("titular")]
        public string Titular;
        [XmlElement("adeudo")]
        public string Adeudo;
        [XmlElement("limiteCredito")]
        public string LimiteCredito;
        [XmlElement("contacto")]
        public string Contacto;
    }
    [XmlRoot("paqueteAlmacen")]
    public class PaqueteAlmacen
    {
        [XmlAttribute("noTarjeta")]
        public string NoTarjeta;
        [XmlElement("producto")]
        public string Producto;
        [XmlElement("costoUnitario")]
        public decimal CostoUnitario;
        [XmlElement("stok")]
        public decimal Stock;
    }

    public class PaqueteVerificacion
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public static int indice = 0;
    }
    public class PaqueteRecuperacion
    {
        public string Nombre { get; set; }
        public string Usuario { get; set; }
        public string Correo { get; set; }
        public string Contrasenia { get; set; }
        public static int indice = 1;
    }
    public class PaqueteFactura
    {
        public string ProductosHtml { get; set; }
        public string Factura { get; set; }
        public string Colaborador { get; set; }
        public string Destinatario { get; set; }
        public string Emisor { get; set; }
        public string FechaEmision { get; set; }
        public string FechaExpiracion { get; set; }
        public string Subtotal { get; set; }
        public string IVA { get; set; }
        public string Total { get; set; }
        public static int indice = 2;
    }
    public class PaqueteProducto
    {
        public string Producto { get; set; }
        public decimal Cantidad { get; set; }
        public string TextoCostoUni { get; set; }
        public decimal Monto { get; set; }
    }
}
