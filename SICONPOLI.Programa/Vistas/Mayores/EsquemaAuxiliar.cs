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
    public partial class EsquemaAuxiliar : Form
    {
        public delegate void ManejadorEliminador();
        public event ManejadorEliminador SolicitarEliminacion;

        public EsquemaAuxiliar(Mayor Titular)
        {
            InitializeComponent();
            CargarMayor(Titular);
        }

        public void CargarMayor(Mayor Titular)
        {
            lblCuenta.Text = Titular.Cuenta;
            lblNoTarjeta.Text = Titular.NoTargeta;
            lblNombre.Text = Titular.Titular;

            foreach (RenMayor renglon in Titular.RenMayores)
            {
                bool Sube = renglon.Movimiento.Saldo == (Titular.Cuenta == Cuentas.Clientes.ToString() ? Saldos.Deudor : Saldos.Acredor).ToString();
                TablaAuxiliar.Rows.Add(
                    renglon.Fecha,
                    renglon.Factura,
                    renglon.Concepto,
                    renglon.Folio,
                    Sube ? $"{(renglon.Movimiento.Monto) : C2}" : "",
                    Sube ? "" : $"{(renglon.Movimiento.Monto): C2}",
                    renglon.MontoSaldo);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SolicitarEliminacion?.Invoke();
        }
    }
}
