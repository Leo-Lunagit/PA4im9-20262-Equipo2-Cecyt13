using PA4IM9_20262_Equipo2.Entidades;
using PA4IM9_20262_Equipo2.Modulos;
using PA4IM9_20262_Equipo2.Vistas.FormulariosRegistros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace PA4IM9_20262_Equipo2.Vistas.Catalogos
{
    public partial class Catalogo : Form
    {
        private Cuentas Cuenta;
        public Catalogo(Cuentas CuentaCatalogo)
        {
            InitializeComponent();

            Cuenta = CuentaCatalogo;
        }

        private void Catalogo_Load(object sender, EventArgs e)
        {
            string Ruta =
                Cuenta == Cuentas.Almacen ? Rutas.Productos :
                Cuenta == Cuentas.Clientes ? Rutas.Clientes :
                Rutas.Proveedores;
            string Raiz =
                Cuenta == Cuentas.Almacen ? Raices.Productos :
                Cuenta == Cuentas.Clientes ? Raices.Clientes :
                Raices.Proveedores;

            Sistema.VerificarArchivo(Ruta, Raiz);
            XmlDocument lector = new XmlDocument();
            lector.Load(Ruta);

            if (Cuenta == Cuentas.Almacen)
            {
                foreach (XmlElement RegProducto in lector.DocumentElement.ChildNodes)
                {
                    PaqueteAlmacen Producto = ConvertidorXml.ElementoToObjeto<PaqueteAlmacen>(RegProducto);
                    TarjetaProducto tarjetita = new TarjetaProducto(Producto);
                    Sistema.IndexarControles(flpVistaProduc, tarjetita);
                }
            }
            else
            {
                foreach (XmlElement RegProducto in lector.DocumentElement.ChildNodes)
                {
                    PaqueteTitular Titular = ConvertidorXml.ElementoToObjeto<PaqueteTitular>(RegProducto);
                    TarjetaTitular tarjetita = new TarjetaTitular(Titular);
                    Sistema.IndexarControles(flpVistaProduc, tarjetita);
                }
            }
        }
    }
}
