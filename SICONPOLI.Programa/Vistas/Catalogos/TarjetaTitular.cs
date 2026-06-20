using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PA4IM9_20262_Equipo2.Entidades;

namespace PA4IM9_20262_Equipo2.Vistas.Catalogos
{
    public partial class TarjetaTitular : UserControl
    {
        public TarjetaTitular(PaqueteTitular Titular)
        {
            InitializeComponent();
            CompletarComponentes(Titular);
        }

        private void CompletarComponentes(PaqueteTitular Titular)
        {
            txtNoTarjeta.Text = Titular.NoTarjeta;
            txtTitular.Text = Titular.Titular;
            txtAdeudo.Text = $"{Titular.Adeudo}";
            txtLimite.Text = $"{Titular.LimiteCredito}";
            txtContacto.Text = Titular.Contacto;
        }
    }
}
