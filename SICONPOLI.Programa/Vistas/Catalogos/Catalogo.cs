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
        public Catalogo()
        {
            InitializeComponent();
        }

        private void Catalogo_Load(object sender, EventArgs e)
        {
            Sistema.VerificarArchivo(Rutas.Almacen, Raices.Almacen);
            XmlDocument lector = new XmlDocument();
            lector.Load(Rutas.Almacen);

            foreach (XmlElement RegProducto in lector.DocumentElement.ChildNodes)
            {
                Almacen Producto = ConvertidorXml.ElementoToObjeto<Almacen>(RegProducto);
                Productos tarjetita = new Productos(Producto);
                Sistema.IndexarControles(flpVistaProduc, tarjetita);
            }
        }
    }
}
