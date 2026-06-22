using PA4IM9_20262_Equipo2.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace PA4IM9_20262_Equipo2.Vistas.Mayores
{
    public partial class EsquemaAuxiliar : Form
    {
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

            if (Titular.RenMayores == null) return;
            foreach (RenMayor renglon in Titular.RenMayores)
            {
                bool Sube = renglon.Movimiento.Saldo == (Titular.Cuenta == Cuentas.Clientes.ToString() ? Saldos.Deudor : Saldos.Acredor).ToString();
                TablaAuxiliar.Rows.Add(
                    renglon.Fecha,
                    renglon.Factura,
                    renglon.Concepto,
                    renglon.Folio,
                    Sube ? $"{(renglon.Movimiento.Monto / 100):C2}" : "",
                    Sube ? "" : $"{(renglon.Movimiento.Monto / 100):C2}",
                    $"{(renglon.MontoSaldo / 100):C2}");
            }
        }

        //
        // Logica de eventos.
        //
        public delegate void ClickRegresar(Cuentas Cuenta, object sender);
        public event ClickRegresar SolicitarRegresar;

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            SolicitarRegresar?.Invoke(Cuenta: lblCuenta.Text == $"{Cuentas.Clientes}" ? Cuentas.Clientes : Cuentas.Proveedores, sender: null);
        }
    }
}
