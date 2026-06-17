using PA4IM9_20262_Equipo2.Entidades;
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

namespace PA4IM9_20262_Equipo2.Vistas.FormulariosRegistros
{
    public partial class FormularioFacturaciones : Formulario
    {
        public FormularioFacturaciones(Cuentas cuentaTitular) : base(cuentaTitular)
        {
            InitializeComponent();
        }
        protected override void CompletarComponentes(Cuentas cuenta)
        {
            base.CompletarComponentes(cuenta);
            Sistema.IndexarCampos(this, this.ContenedorRecursos, new CamposProducto(), Cuentas.Almacen);
        }
        //
        // Logica de Validaciones
        //
        public override bool SumasIguales()
        {
            if (txtSumaTotal.Text == "" || txtIVA.Text == "" || txtSumaTotal.Text == "") return true;

            decimal CostoTotal = decimal.Parse(txtSumaTotal.Text, NumberStyles.Currency, CultureInfo.CurrentCulture);
            decimal IVA = decimal.Parse(txtIVA.Text, NumberStyles.Currency, CultureInfo.CurrentCulture);
            decimal MontoToal = decimal.Parse(txtMontoTotal.Text, NumberStyles.Currency, CultureInfo.CurrentCulture);

            bool Iguales = CostoTotal + IVA == MontoToal;
            return Iguales;
        }
    }
}
