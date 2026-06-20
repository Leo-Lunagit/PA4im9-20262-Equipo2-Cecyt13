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
    public partial class TarjetaProducto : UserControl
    {
        public delegate void Entrar(string noTarjetita);
        public event Entrar EntrarProducto;

        public TarjetaProducto(PaqueteAlmacen Producto)
        {
            InitializeComponent();
            CompletarComponentes(Producto);
        }
        private void CompletarComponentes(PaqueteAlmacen producto)
        {
            lblproducto.Text = producto.Producto;
            lblcostopromedio.Text = $"{(producto.CostoUnitario / 100):C2}";
            lblcantidad.Text = $"{producto.Stock}";
            lblNoTarjeta.Text = producto.NoTarjeta;
        }

        private void Click_EntrarProducto(object sender, EventArgs e)
        {
            EntrarProducto?.Invoke(lblNoTarjeta.Text);
        }
    }
}
