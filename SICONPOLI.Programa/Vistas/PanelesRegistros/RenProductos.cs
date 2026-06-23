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

namespace PA4IM9_20262_Equipo2.Vistas.PanelesRegistros
{
    public partial class RenProductos : UserControl
    {
        public RenProductos(PaqueteProducto producto)
        {
            InitializeComponent();

            txtProducto.Text = producto.Producto;
            txtCantidad.Text = $"{producto.Cantidad}";
            txtMonto.Text = $"{(producto.Monto/100):C2}";
        }
    }
}
