using PA4IM9_20262_Equipo2.Modulos;
using PA4IM9_20262_Equipo2.Vistas.CamposSubCuentas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Diagnostics.Eventing.Reader;
using PA4IM9_20262_Equipo2.Entidades;

namespace PA4IM9_20262_Equipo2.Vistas.PanelVentas
{
    public partial class FormularioVentas : UserControl
    {
        // Variables para poder regrezar los campos.
        protected CamposTitular TitularEliminado = null;
        protected CamposProducto ProductoEliminado = null;
        // 
        // Logica de carga.
        //
        public FormularioVentas()
        {
            InitializeComponent();

            // Incrusta un lote controles para los campos de productos.
            //Sistema.IndexarCampos(this, this.ContenedorProductos, new CamposProducto(), Cuentas.Almacen);
            // Incrusta un lote de controles para los campos de clientes.
            //Sistema.IndexarCampos(this, this.ContenedorClientes, new CamposTitular(), Cuentas.Clientes);
        }
        //
        // Logica de validaciones.
        //
        public bool CamposCompletos()
        {
            bool CargosCompletos = true;
            int NoCargos = ContenedorProductos.Controls.Count;
            foreach (Campos productos in ContenedorProductos.Controls)
                CargosCompletos = CargosCompletos && productos.CamposCompletos(NoCargos != 1);

            bool AbonosCompletos = true;
            int NoAbonos = ContenedorClientes.Controls.Count;
            foreach (Campos clientes in ContenedorClientes.Controls)
                AbonosCompletos = AbonosCompletos && clientes.CamposCompletos(NoAbonos != 1);

            bool CamposCompletos = txtCostoFinal.Text != ""  && txtIVA.Text != "" && txtMontoTotal.Text != "";
            bool Completos = CargosCompletos && AbonosCompletos && CamposCompletos;

            return Completos;
        }
        //
        // Logica de Eventos
        //
        public void CambiarSumaTotal(decimal CostoCambiado, Cuentas Cuenta)
        {
            // Dinamicamente obtenemos los controles nesesarios.
            Elementos Elementos = new Elementos
            {
                txtSumaFinal = Cuenta == Cuentas.Almacen ? txtCostoFinal : txtMontoTotal,
                txtIVA = Cuenta == Cuentas.Almacen ? txtIVA : null
            };

            decimal SumaTotal = 0; // En cero por si esta vacio el campo.
            if (Elementos.txtSumaFinal.Text != "") 
                // Si no esta vacio obtinene el valor del txt.
                SumaTotal = decimal.Parse(Elementos.txtSumaFinal.Text, NumberStyles.Currency, CultureInfo.CurrentCulture);
            // Hace la actualizacion de la suma.
            SumaTotal += CostoCambiado;
            // La refleja en el txt.
            Elementos.txtSumaFinal.Text = $"{SumaTotal:C}";

            // Solo si requiere de IVA.
            if (Elementos.txtIVA != null)
            {
                // Obtiene el nuevo IVA y lo refleja.
                decimal IVA = SumaTotal * .16m;
                Elementos.txtIVA.Text = $"{IVA:C}";
            }
        }
        public void AgregarCampos(Cuentas Cuenta)
        {
            // Dinamicamente obtenemos los controles nesesarios.
            Elementos Elementos = new Elementos
            {
                Contenedor = Cuenta == Cuentas.Almacen ? ContenedorProductos : ContenedorClientes,
                Campos = Cuenta == Cuentas.Almacen ? (Campos)new CamposProducto() : new CamposTitular(),
                lblNoItems = Cuenta == Cuentas.Almacen ? lblNoProductos : lblNoClientes,
            };

            // Agregamos una nueva fila de campos.
            //Sistema.IndexarCampos(this, Elementos.Contenedor, Elementos.Campos, Cuenta);
            // Obtenemos el numero de filas.
            int CamposTotal = Elementos.Contenedor.Controls.Count;
            // Indicamos el numero de filas.
            Elementos.lblNoItems.Text = $"{CamposTotal}";
        }
        public void ElinarCampos(int NumeroProducto, Cuentas Cuenta)
        {
            // Dinamicamente obtenemos los controles nesesarios.
            Elementos Elementos = new Elementos
            {
                Contenedor = Cuenta == Cuentas.Almacen ? ContenedorProductos : ContenedorClientes,
                lblNoItems = Cuenta == Cuentas.Almacen ? lblNoProductos : lblNoClientes,
                CampoEliminado = Cuenta == Cuentas.Almacen ? (Campos)ProductoEliminado : TitularEliminado
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

    // Clase plana (tan solo contiene datos) para los controles compartidos y nesesatios entre formularios.
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
