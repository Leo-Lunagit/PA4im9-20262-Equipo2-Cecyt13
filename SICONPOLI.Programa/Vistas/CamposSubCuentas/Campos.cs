using PA4IM9_20262_Equipo2.Entidades;
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

namespace PA4IM9_20262_Equipo2.Vistas.CamposSubCuentas
{
    public partial class Campos : UserControl
    {
        public Cuentas? Cuenta = null;
        decimal CostoAnterior = 0;
        //
        // Logica de carga
        //
        public Campos()
        {
            InitializeComponent();
        }
        private void Campos_ParentChanged(object sender, EventArgs e)
        {
            if(this.Parent != null)
                lblNoItem.Text = this.Parent.Controls.Count.ToString();
        }
        // 
        // Logica de Eventos
        // 

        // Manejadores de eventos (dictan el tipo de dato de retorno y los parametros que debe recibir).
        public delegate void CambioCostoHandler(decimal Costo, Cuentas Cuenta);
        public delegate void AutoEliminarHandler(int Indice, Cuentas Cuenta);
        public delegate void OcupaEspacioHandler(Cuentas Cuenta);
        // Eventos 
        public event CambioCostoHandler CambiarCostoTotal;
        public event AutoEliminarHandler LlamarAutoEliminacion;
        public event OcupaEspacioHandler AgregarEspacioItem;

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            LlamarAutoEliminacion?.Invoke(int.Parse(lblNoItem.Text), (Cuentas)Cuenta);
        }

        private void txtCosto_TextChanged(object sender, EventArgs e)
        {
            if (txtMonto.Text == "" || txtMonto.Text == ".")
            {
                CambiarCostoTotal?.Invoke(CostoAnterior * -1, (Cuentas)Cuenta);
                CostoAnterior = 0;
            }
            else
            {
                decimal Costo = decimal.Parse(txtMonto.Text, NumberStyles.Currency, CultureInfo.CurrentCulture);
                CambiarCostoTotal?.Invoke(Costo - CostoAnterior, (Cuentas)Cuenta);
                CostoAnterior = Costo;
            }
        }
        //
        // Logica de validaciones.
        //
        public virtual bool CamposCompletos(bool Hermanos) 
        {
            return true;   
        }
        public virtual bool CampoNulo() 
        {
            return true;   
        }
    }
}
