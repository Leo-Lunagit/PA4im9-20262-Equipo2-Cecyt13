using PA4IM9_20262_Equipo2.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PA4IM9_20262_Equipo2.Vistas.Catalogos
{
    public partial class Productos : UserControl
    {
        Almacen Producto;
        public Productos(Almacen Producto)
        {
            InitializeComponent();
            CompletarComponentes(Producto);
        }
        private void CompletarComponentes(Almacen producoto)
        {
            Producto = producoto;

            lblproducto.Text = producoto.Producto;
            lblcostopromedio.Text = producoto.CostoUnitario.ToString();
            lblcantidad.Text = producoto.Stock.ToString();
        }
    }
}
