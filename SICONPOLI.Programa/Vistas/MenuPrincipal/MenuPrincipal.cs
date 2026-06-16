using PA4IM9_20262_Equipo2.Entidades;
using PA4IM9_20262_Equipo2.Modulos;
using PA4IM9_20262_Equipo2.Vistas.Panel_Principal;
using PA4IM9_20262_Equipo2.Vistas.PanelVentas;
using PA4IM9_20262_Equipo2.Vistas.PanelMapa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PA4IM9_20262_Equipo2.Vistas.Panel_Principal
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        //
        // Logica de ventanas.
        //
        private void CerrarPaneles()
        {
            // Si el contendero tiene elementos, los elimina
            if (this.Contenedor.Controls.Count > 0)
                this.Contenedor.Controls.RemoveAt(0);
            DesIndexarPanel();
        }
        private void AbrirPaneles(object panel, object sender)
        {
            // Si el contendero tiene elementos, los elimina
            if (this.Contenedor.Controls.Count > 0)
                this.Contenedor.Controls.RemoveAt(0);
            // Transforma el objeto a formulario.
            Form Panel = panel as Form;
            Panel.TopLevel = false; // Indica que no es un formulario de alto nivel, si no subordinado.
            Panel.Dock = DockStyle.Fill; // Indica que ocupe todo el espacio.
            this.Contenedor.Controls.Add(Panel); // Agrega el control al contenedor.
            this.Contenedor.Tag = Panel;
            Panel.Show(); // Muestra el panel.
            IndexarPanel(sender);
        }
        private void IndexarPanel(object sender)
        {
            Button boton = sender as Button;
            Contenedor.TabIndex = boton.TabIndex++;
            Contenedor.TabStop = true;
        }
        private void DesIndexarPanel() { Contenedor.TabStop = false; }
        private void btnHome_Click(object sender, EventArgs e) { CerrarPaneles(); }
        private void btnEntradas_Click(object sender, EventArgs e) { AbrirPaneles(new Panel_de_compras(), sender); }
        private void btnSalidas_Click(object sender, EventArgs e) { AbrirPaneles(new Panel_Ventas(), sender); }
        private void btnClientes_Click(object sender, EventArgs e) { CerrarPaneles(); }
        private void btnProvedores_Click(object sender, EventArgs e) { CerrarPaneles(); }
        private void btnAlmacen_Click(object sender, EventArgs e) { CerrarPaneles(); }
        private void btnSucursales_Click(object sender, EventArgs e) { AbrirPaneles(new Panel_Mapa(), sender); }
        private void btnUsuario_Click(object sender, EventArgs e) { CerrarPaneles(); }
        private void btnConfig_Click(object sender, EventArgs e) { CerrarPaneles(); }
        private void MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e) { Application.Exit(); }

        //
        // Logica de utilidades.
        //
        private bool HoverOpsiones = true;
        private void btnOpciones_MouseHover(object sender, EventArgs e) { if (HoverOpsiones) panOpciones.Visible = true; }

        private void btnOpciones_MouseLeave(object sender, EventArgs e) { if (HoverOpsiones) panOpciones.Visible = false; }

        private void btnOpciones_Click(object sender, EventArgs e)
        {
            panOpciones.Visible = HoverOpsiones;
            HoverOpsiones = !HoverOpsiones;
        } 
        private void panOpciones_MouseHover(object sender, EventArgs e) {
            if (panOpciones.Visible)
            {
                HoverOpsiones = false;
                panOpciones.Visible = true;
            }
        }
        private void panOpciones_MouseLeave(object sender, EventArgs e)
        {
            if (HoverOpsiones) 
            {
                HoverOpsiones = true;
                panOpciones.Visible = false;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            PanelAcceso ventana = new PanelAcceso();
            ventana.RecomendarActivo();
            ventana.Show();
            this.Hide();
        }
    }
}
