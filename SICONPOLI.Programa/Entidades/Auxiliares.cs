using PA4IM9_20262_Equipo2.Vistas.Catalogos;
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
        public decimal Monto { get; set; }
    } 

    public class Contactos
    {
        [XmlElement("domicilio")]
        public string Domicilio { get; set; }
        [XmlElement("coreo")]
        public string Correo { get; set; }
        [XmlElement("telefono")]
        public string Telefono { get; set; }
        [XmlElement("linkImagen")]
        public string LinkImagen { get; set; }
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
        public decimal MontoSaldo { get; set; }
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
        [XmlElement("datosContacto")]
        public Contactos DatosContacto { get; set; }
        [XmlElement("limiteCredito")]
        public string LimiteCredito { get; set; }
        [XmlArray("movMayores")]
        [XmlArrayItem("renMayores")]
        public RenMayor[] RenMayores { get; set; }

        public PaqueteTitular ToPaquete()
        {
            decimal monto = 0;
            if (RenMayores != null)
                 monto = RenMayores.Last().MontoSaldo;
            string adeudo = monto == 0 ? "Saldado." : $"{(monto / 100):C2}";
            Contactos Contactos = DatosContacto;
            string contacto =
                DatosContacto == null ? "Sin Contacto." :
                DatosContacto.Correo != "" ? DatosContacto.Correo :
                DatosContacto.Telefono != "" ? DatosContacto.Telefono :
                "Sin Contacto.";
            PaqueteTitular Paquete = new PaqueteTitular 
            {
                NoTarjeta = this.NoTargeta,
                Titular = this.Titular,
                Adeudo = adeudo,
                LimiteCredito = this.LimiteCredito,
                Contacto = contacto
            };
            return Paquete;
        }
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
        public decimal Existencia { get; set; }
        [XmlElement("costo")]
        public decimal CostoUnitario { get; set; }
        [XmlElement("movValor")]
        public decimal CostoPromedio { get; set; }
        public Movimiento MovValor { get; set; }
        [XmlElement("montoSaldo")]
        public decimal MontoSaldo { get; set; }
    }

    [XmlRoot("almacen")]
    public class Almacen
    {
        [XmlAttribute("noTarjeta")]
        public string NoTarjeta { get; set; }
        [XmlElement("producto")]
        public string Producto { get; set; }
        [XmlArray("movAlmacen")]
        [XmlArrayItem("renAlmacen")]
        public RenAlmacen[] RenAlmacens { get; set; }
        [XmlElement("linkImagen")]
        public string LinkImagen { get; set; }

        public PaqueteAlmacen ToPaquete()
        {
            PaqueteAlmacen Paquete = new PaqueteAlmacen
            {
                NoTarjeta = this.NoTarjeta,
                Producto = this.Producto,
                Stock = this.RenAlmacens.Last().Existencia,
                CostoUnitario = this.RenAlmacens.Last().CostoPromedio,
            };
            return Paquete;
        }
    }
}
