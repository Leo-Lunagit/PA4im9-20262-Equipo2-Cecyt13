using PA4IM9_20262_Equipo2.Entidades;
using PA4IM9_20262_Equipo2.Modulos;
using PA4IM9_20262_Equipo2.Vistas.CamposSubCuentas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PA4IM9_20262_Equipo2.Vistas.FormulariosRegistros
{
    public partial class Formulario : UserControl
    {
        public Cuentas CuentaTitular;
        // Variables para poder regrezar los campos.
        protected Campos RecursoEliminado = null; // Bancos y Almacen no.
        //
        // Logica de carga.
        //
        public Formulario()
        {
            InitializeComponent();
        }
        protected virtual void CompletarComponentes(Cuentas cuenta)
        {
            CuentaTitular = cuenta;

            grpTitulares.Text = CuentaTitular.ToString();
            lblTitulares.Text = CuentaTitular.ToString();
            if (cuenta == Cuentas.Proveedores) RecorrerLblTitulares();
        }
        //
        // Logica de Validaciones.
        //
        private void VentanaInco(string mensaje)
        {
            MessageBox.Show(mensaje, "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        public bool CamposCorrectos()
        {
            // Para evaluar que todos los campos sean correctos se compara cada un con el anterior. 
            bool RecursosCompletos = true;
            int NoRecursos = ContenedorRecursos.Controls.Count;
            foreach (Campos Recurso in ContenedorRecursos.Controls)
                RecursosCompletos = RecursosCompletos && Recurso.CamposCompletos(NoRecursos != 1);

            if (!RecursosCompletos)
            {
                VentanaInco("Por favor complete los datos de los productos");
                return false;
            }

            if (txtTitular.Text == "" || txtFactura.Text == "")
            {
                VentanaInco("Por favor complete los datos del titular.");
                return false;
            }
            // Se verifican los campos de los totales.
            if (txtSubTotal.Text == "" && txtIVA.Text == "" && txtMontoTotal.Text == "")
            {
                VentanaInco("Complete los datos para obtener totales.");
                return false;
            }
            
            return true; // Manda el resultado.
        }
        //
        // Logica de utilidades.
        //
        private void RecorrerLblTitulares()
        {
            lblTitulares.Location = new Point(lblTitulares.Location.X - 11, lblTitulares.Location.Y);
        }
        //
        // Logica de eventos
        //
        public void CambiarSumaTotal(decimal CostoCambiado, Cuentas Cuenta)
        {
            decimal SumaTotal = 0; // En cero por si esta vacio el campo.
            if (txtSubTotal.Text != "")
                // Si no esta vacio obtinene el valor del txt.
                SumaTotal = decimal.Parse(txtSubTotal.Text, NumberStyles.Currency, CultureInfo.CurrentCulture);
            // Hace la actualizacion de la suma.
            SumaTotal += CostoCambiado;
            // La refleja en el txt.
            txtSubTotal.Text = $"{SumaTotal:C}";

            txtIVA.Text = $"{(SumaTotal * .16m):C2}";
            txtMontoTotal.Text = $"{(SumaTotal * 1.16m):C2}";
        }
        public void AgregarCampos(Cuentas Cuenta)
        {
            bool EsAlmacen = Cuenta == Cuentas.Almacen;
            Campos Campos = EsAlmacen ? new CamposProducto(Cuenta) : (Campos)(new CamposBancos());

            // Agregamos una nueva fila de campos.
            Sistema.IndexarCampos(this, ContenedorRecursos, Campos, Cuenta);
            // Obtenemos el numero de filas.
            int CamposTotal = ContenedorRecursos.Controls.Count;
            // Indicamos el numero de filas.
            lblNoRecursos.Text = $"{CamposTotal}";
        }
        public void ElinarCampos(int NumeroProducto, Cuentas Cuenta)
        {
            // Si solo hay una fila no eliminamos nada.
            if (ContenedorRecursos.Controls.Count == 1) return;

            int Indice = NumeroProducto - 1; // De No. a indice.
            // Guardamos la fila a eliminar para poder hacer ctl z.
            RecursoEliminado = ContenedorRecursos.Controls[Indice] as Campos;

            if (RecursoEliminado.txtMonto.Text != "")
            {
                // Resta su suma a la total.
                decimal Suma = decimal.Parse(RecursoEliminado.txtMonto.Text, NumberStyles.Currency, CultureInfo.CurrentCulture);
                CambiarSumaTotal(Suma * -1, Cuenta);
            }

            // Eliminamos la fila.
            ContenedorRecursos.Controls.RemoveAt(Indice);

            // Iniciamos una variable para enumerar las filas.
            int NoRecursos = 0;
            // Por cada fila en el campo
            foreach (Campos producto in ContenedorRecursos.Controls)
            {
                // Va sumando uno al inicio para terminar con el numero exacto de filas y poder usar la variable despues.
                NoRecursos++;
                // Enumeramos la fila.
                producto.lblNoItem.Text = $"{NoRecursos}";
            }

            // Cambiamos el total de filas.
            lblNoRecursos.Text = $"{NoRecursos}";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (ContenedorRecursos.Controls.Count < 4) 
                AgregarCampos(CuentaTitular);
        }

        //
        // Logica de Eventos
        //
        public delegate void AutoEliminar();
        public event AutoEliminar ClickEliminar; 
        private void btnSalir_Click(object sender, EventArgs e)
        {
            ClickEliminar?.Invoke();
        }
    }
}
