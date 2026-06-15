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
        protected CamposTitular TitularEliminado = null; // Proveedores y Clientes son iguales.
        protected Campos RecursoEliminado = null; // Bancos y Almacen no.
        //
        // Logica de carga.
        //
        public Formulario(Cuentas cuentaTitular)
        {
            InitializeComponent();
            CompletarComponentes(cuentaTitular);
        }
        protected virtual void CompletarComponentes(Cuentas cuenta)
        {
            CuentaTitular = cuenta;

            grpTitulares.Text = CuentaTitular.ToString();
            lblTitulares.Text = CuentaTitular.ToString();
            if (cuenta == Cuentas.Proveedores) RecorrerLblTitulares();

            Sistema.IndexarCampos(this, this.ContenedorTitulares, new CamposTitular(), CuentaTitular);
        }
        //
        // Logica de Validaciones.
        //
        public bool CamposCorrectos()
        {
            // Si las sumas no son iguales falla la verificacion.
            if (!SumasIguales())
            {
                MessageBox.Show("Por favor rectifique que los datos coincidan.", "Sumas desiguales", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true; 
            }

            // Para evaluar que todos los campos sean correctos se compara cada un con el anterior. 
            bool RecursosCompletos = true;
            int NoRecursos = ContenedorRecursos.Controls.Count;
            foreach (Campos Recurso in ContenedorRecursos.Controls)
                RecursosCompletos = RecursosCompletos && Recurso.CamposCompletos(NoRecursos != 1);

            // Se inicia en true para que la primera validacion, con ningun campo, no afecte.
            bool TitularesCompletos = true;
            int NoTitulares = ContenedorTitulares.Controls.Count;
            foreach (Campos Titular in ContenedorTitulares.Controls)
                TitularesCompletos = TitularesCompletos && Titular.CamposCompletos(NoTitulares != 1);

            // Se verifican los campos de los totales.
            bool CamposCompletos = txtSumaTotal.Text != "" && txtIVA.Text != "" && txtMontoTotal.Text != "";
            // Se evaluan todas las partes.
            bool Completos = RecursosCompletos && TitularesCompletos && CamposCompletos;

            return Completos; // Manda el resultado.
        }
        public virtual bool SumasIguales()
        {
            return true;
        }
        //
        // Logica de utilidades.
        //
        private void RecorrerLblTitulares()
        {
            lblTitulares.Location = new Point(lblTitulares.Location.X - 11, lblTitulares.Location.Y);
            lblNoTitulares.Location = new Point(lblNoTitulares.Location.X + 11, lblNoTitulares.Location.Y);
        }
        //
        // Logica de eventos
        //
        public void CambiarSumaTotal(decimal CostoCambiado, Cuentas Cuenta)
        {
            bool EsRecurso = Cuenta == Cuentas.Almacen || Cuenta == Cuentas.Bancos;
            // Dinamicamente obtenemos los controles nesesarios.
            Elementos Elementos = new Elementos
            {
                txtSumaFinal = EsRecurso ? txtSumaTotal : txtMontoTotal,
                txtIVA = EsRecurso ? txtIVA : null
            };

            decimal SumaTotal = 0; // En cero por si esta vacio el campo.
            if (Elementos.txtSumaFinal.Text != "")
                // Si no esta vacio obtinene el valor del txt.
                SumaTotal = decimal.Parse(Elementos.txtSumaFinal.Text, NumberStyles.Currency, CultureInfo.CurrentCulture);
            // Hace la actualizacion de la suma.
            SumaTotal += CostoCambiado;
            // La refleja en el txt.
            Elementos.txtSumaFinal.Text = $"{SumaTotal:C}";

            // Solo si requiere de IVA obtiene el nuevo IVA y lo refleja.
            if (Elementos.txtIVA != null)
            {
                // Si es almacen se agrega el IVA.
                // Si es banco se determina el IVa.
                decimal IVA = Cuenta == Cuentas.Almacen ? SumaTotal * .16m : (SumaTotal / 1.16m) * .16m;
                Elementos.txtIVA.Text = $"{IVA:C}";
            }
        }
        public void AgregarCampos(Cuentas Cuenta)
        {
            bool EsRecurso = Cuenta == Cuentas.Almacen || Cuenta == Cuentas.Bancos;
            bool EsAlmacen = Cuenta == Cuentas.Almacen;
            // Dinamicamente obtenemos los controles nesesarios.
            Elementos Elementos = new Elementos
            {
                Contenedor = EsRecurso ? ContenedorRecursos : ContenedorTitulares,
                lblNoItems = EsRecurso ? lblNoRecursos : lblNoTitulares,
                Campos = EsAlmacen ? (Campos)new CamposProducto() : new CamposTitular(),
            };

            // Agregamos una nueva fila de campos.
            Sistema.IndexarCampos(this, Elementos.Contenedor, Elementos.Campos, Cuenta);
            // Obtenemos el numero de filas.
            int CamposTotal = Elementos.Contenedor.Controls.Count;
            // Indicamos el numero de filas.
            Elementos.lblNoItems.Text = $"{CamposTotal}";
        }
        public void ElinarCampos(int NumeroProducto, Cuentas Cuenta)
        {
            bool EsRecurso = Cuenta == Cuentas.Almacen || Cuenta == Cuentas.Bancos;
            // Dinamicamente obtenemos los controles nesesarios.
            Elementos Elementos = new Elementos
            {
                Contenedor = EsRecurso ? ContenedorRecursos: ContenedorTitulares,
                lblNoItems = EsRecurso ? lblNoRecursos : lblNoTitulares,
                CampoEliminado = Cuenta == Cuentas.Almacen ? RecursoEliminado : TitularEliminado
            };

            // Si solo hay una fila no eliminamos nada.
            if (Elementos.Contenedor.Controls.Count == 1) return;

            int Indice = NumeroProducto - 1; // De No a indice.
            // Guardamos la fila a eliminar para poder ahcer ctl z.
            Elementos.CampoEliminado = Elementos.Contenedor.Controls[Indice] as Campos;

            if (Elementos.CampoEliminado.txtMonto.Text != "")
            {
                // Resta su suma a la total.
                decimal Suma = decimal.Parse(Elementos.CampoEliminado.txtMonto.Text, NumberStyles.Currency, CultureInfo.CurrentCulture);
                CambiarSumaTotal(Suma * -1, Cuenta);
            }

            // Eliminamos la fila.
            Elementos.Contenedor.Controls.RemoveAt(Indice);

            // Iniciamos una variable para enumerar las filas.
            int NoProductos = 0;
            // Por cada fila en el campo
            foreach (Campos producto in Elementos.Contenedor.Controls)
            {
                // Va sumando uno al inicio para terminar con el numero exacto de filas y poder usar la variable despues.
                NoProductos++;
                // Enumeramos la fila.
                producto.lblNoItem.Text = $"{NoProductos}";
            }

            // Cambiamos el total de filas.
            Elementos.lblNoItems.Text = $"{NoProductos}";
        }
    }

    internal class Elementos
    {
        public TextBox txtSumaFinal { set; get; }
        public TextBox txtIVA { set; get; }
        public Label lblNoItems { set; get; }
        public Panel Contenedor { set; get; }
        public Campos Campos { set; get; }
        public Campos CampoEliminado { set; get; }
    }
}
