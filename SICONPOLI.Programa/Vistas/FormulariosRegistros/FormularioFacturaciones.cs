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
using System.Xml;

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

            Sistema.VerificarArchivo(Rutas.Productos, Raices.Productos);
            XmlDocument lector = new XmlDocument();
            lector.Load(Rutas.Productos);
            NoRecursos = lector.DocumentElement.ChildNodes.Count;
            if (NoRecursos == 0) NoRecursos++;

            if (!EsClientes)
            {
                cmbFacturas.Visible = false;
                txtFactura.Width += 17;
                txtFactura.ReadOnly = false;
            }
            else
            {
                AutoFactura = GenerarDigitosFactura(4);
                cmbFacturas.SelectedIndex = 0;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (!EsClientes || ContenedorRecursos.Controls.Count < NoRecursos)
                AgregarCampos(Cuentas.Almacen);
        }

        private void cmbFacturas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFacturas.Text == "Automatica")
            {
                txtFactura.Text = AutoFactura;
                txtFactura.ReadOnly = true;
            }
            else
            {
                txtFactura.ReadOnly = false;
                txtFactura.Focus();
            }
        }
    }
}
