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
        public FormularioFacturaciones(Cuentas cuentaTitular) 
        {
            InitializeComponent();
            CompletarComponentes(cuentaTitular);
        }
        protected override void CompletarComponentes(Cuentas cuenta)
        {
            base.CompletarComponentes(cuenta);
            Sistema.IndexarCampos(this, this.ContenedorRecursos, new CamposProducto(cuenta), Cuentas.Almacen);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (ContenedorRecursos.Controls.Count < 4)
                AgregarCampos(Cuentas.Almacen);
        }
    }
}
