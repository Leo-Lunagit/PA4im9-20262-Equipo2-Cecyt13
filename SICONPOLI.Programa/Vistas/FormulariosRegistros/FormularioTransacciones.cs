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

namespace PA4IM9_20262_Equipo2.Vistas.FormulariosRegistros
{
    public partial class FormularioTransacciones : Formulario
    {
        //
        // Logica de Carga.
        //
        public FormularioTransacciones(Cuentas cuentaTitular) : base(cuentaTitular)
        {
            InitializeComponent();
        }
        protected override void CompletarComponentes(Cuentas cuenta)
        {
            base.CompletarComponentes(cuenta);
            Sistema.IndexarCampos(this, this.ContenedorRecursos, new CamposTitular(), Cuentas.Bancos);
        }
        //
        // Logica de Validacion
        //
        public override bool SumasIguales()
        {
            bool Iguales = txtSumaTotal.Text == txtMontoTotal.Text;
            return Iguales;
        }
    }
}
