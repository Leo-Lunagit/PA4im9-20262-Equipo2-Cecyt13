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

namespace PA4IM9_20262_Equipo2.Vistas.Mayores
{
    public partial class TarjetaAlmacen : Form
    {
        public TarjetaAlmacen(Almacen almacen)
        {
            InitializeComponent();
            CompletarCoponentes(almacen);
        }

        private void CompletarCoponentes(Almacen almacen)
        {
            lblNoTarjeta.Text = almacen.NoTarjeta;
            txtProducto.Text = almacen.Producto;

            foreach (RenAlmacen renglon in almacen.RenAlmacens)
            {
                TablaProducto.Rows.Add
                (
                    renglon.Folio,
                    renglon.Fecha,
                    renglon.Factura,
                    renglon.MovInventario.Saldo == $"{Saldos.Deudor}" ? $"{renglon.MovInventario.Monto}" : "---",
                    renglon.MovInventario.Saldo == $"{Saldos.Acredor}" ? $"{renglon.MovInventario.Monto}" : "---",
                    renglon.Existencia,
                    $"{(renglon.CostoUnitario / 100):C2}",
                    $"{(renglon.CostoPromedio / 100):C2}",
                    renglon.MovValor.Saldo == $"{Saldos.Deudor}" ? $"{(renglon.MovValor.Monto / 100):C2}" : "---",
                    renglon.MovValor.Saldo == $"{Saldos.Acredor}" ? $"{(renglon.MovValor.Monto / 100):C2}" : "---",
                    $"{(renglon.MontoSaldo / 100):C2}"
                );
            }
        }

        public delegate void ClickRegresar(Cuentas Cuenta, object sender);
        public event ClickRegresar SolicitarRegresar;

        private void btnRegreso_Click(object sender, EventArgs e)
        {
            SolicitarRegresar?.Invoke(Cuenta: Cuentas.Almacen, sender: null);
        }
    }
}
