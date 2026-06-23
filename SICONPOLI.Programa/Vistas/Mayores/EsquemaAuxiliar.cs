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
using PA4IM9_20262_Equipo2.Vistas.PanelesRegistros;

namespace PA4IM9_20262_Equipo2.Vistas.Mayores
{
    public partial class EsquemaAuxiliar : Form
    {
        Cuentas CuentaTitular;
        Mayor TitularActual;
        public EsquemaAuxiliar(Mayor Titular)
        {
            InitializeComponent();
            CargarMayor(Titular);
        }

        public void CargarMayor(Mayor Titular)
        {
            TitularActual = Titular;
            CuentaTitular = Titular.Cuenta == Cuentas.Proveedores.ToString() ? Cuentas.Proveedores : Cuentas.Clientes;

            lblCuenta.Text = Titular.Cuenta;
            txtNoTarjeta.Text = Titular.NoTargeta;
            txtNombre.Text = Titular.Titular;
            txtDomicilio.Text = Titular.DatosContacto.Domicilio;
            txtCredito.Text = Titular.LimiteCredito;
            txtCorreo.Text = Titular.DatosContacto.Correo;
            txtTelefono.Text = Titular.DatosContacto.Telefono;

            if (Titular.FechaAlta != "") btnRegistrar.Visible = false;
            VerificarRegistroCompleto(); 

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
        private void VerificarRegistroCompleto()
        {
            if (txtDomicilio.Text != "Sin Aclarar." && txtCredito.Text != "Sin Aclarar" && txtTelefono.Text != "Sin Aclarar." && txtCorreo.Text != "Sin Aclarar." && TitularActual.DatosContacto.LinkImagen != "")
            {
                btnRegistrar.Text = "Modificar";
                return;
            }
            else if (TitularActual.FechaAlta != "")
            {
                btnRegistrar.Width += 75;
                btnRegistrar.Location = new Point(btnRegistrar.Location.X - 38, btnRegistrar.Location.Y);
                btnRegistrar.Text = "Terminar Registro";
                return;
            }
           

            DialogResult resultado = MessageBox.Show("El titular actual no ha sido registrado. ¿Quiere registrar el titular ahora mismo?", "Titular NO encontrado.", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (resultado == DialogResult.Yes)
            {
                Contactos contactos = TitularActual.DatosContacto;
                PaqueteTitular paquete = TitularActual.ToPaquete();
                AgregarTitular ventana = new AgregarTitular(paquete, contactos, CuentaTitular);
                ventana.ShowDialog();
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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Contactos contactos = TitularActual.DatosContacto;
            PaqueteTitular paquete = TitularActual.ToPaquete();
            AgregarTitular ventana = new AgregarTitular(paquete, contactos, CuentaTitular);
            ventana.ShowDialog();
        }
    }
}
