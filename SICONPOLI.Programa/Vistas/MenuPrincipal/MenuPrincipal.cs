using PA4IM9_20262_Equipo2.Entidades;
using PA4IM9_20262_Equipo2.Modulos;
using PA4IM9_20262_Equipo2.Vistas.Catalogos;
using PA4IM9_20262_Equipo2.Vistas.Mayores;
using PA4IM9_20262_Equipo2.Vistas.Panel_Principal;
using PA4IM9_20262_Equipo2.Vistas.PanelVentas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;


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
        private void CerrarPaneles(object sender)
        {
            // Da el fondo clarito al boton seleccionado.
            ColorearSeleccion(sender);

            // Si el contendero tiene elementos, los elimina
            if (this.Contenedor.Controls.Count > 0)
                this.Contenedor.Controls.RemoveAt(0);

            // Agrega (hace aparecer) el picture box con el logo.
            this.Contenedor.Controls.Add(this.marcaAgua);
        }
        private void AbrirPaneles(object formularioHijo, object sender)
        {
            // Da el fondo clarito al boton seleccionado.
            ColorearSeleccion(sender);

            // Incrusta el formulario en el panel.
            Sistema.IndexarFormulario(this.Contenedor, formularioHijo);
        }
        private void ColorearSeleccion(object sender)
        {
            Button botonColoreado = this.BarraLateral.Controls.OfType<Button>().FirstOrDefault(btn => btn.BackColor == Color.FromArgb(200, 220, 215));
            if (botonColoreado != null) 
                botonColoreado.BackColor = Color.White;
            
            Button boton = sender as Button;
            boton.BackColor = Color.FromArgb(200, 220, 215);
        }
        private void btnHome_Click(object sender, EventArgs e) { CerrarPaneles(sender); }
        private void btnEntradas_Click(object sender, EventArgs e) { AbrirPaneles(new PanelRegistros(Cuentas.Proveedores), sender); }
        private void btnSalidas_Click(object sender, EventArgs e) { AbrirPaneles(new PanelRegistros(Cuentas.Clientes), sender); }
        private void btnClientes_Click(object sender, EventArgs e) { IndexarCatalogoTitulares(new Catalogo(Cuentas.Clientes), sender); }
        private void btnProvedores_Click(object sender, EventArgs e) { IndexarCatalogoTitulares(new Catalogo(Cuentas.Proveedores), sender); }
        private void btnAlmacen_Click(object sender, EventArgs e) { AbrirPaneles(new Catalogo(Cuentas.Almacen), sender); }
        private void btnSucursales_Click(object sender, EventArgs e) 
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.google.com/maps/search/recicaldora+de+electronicos+coyoacan/@19.3728181,-99.1949944,15z?entry=ttu&g_ep=EgoyMDI2MDYxNi4wIKXMDSoASAFQAw%3D%3D",
                UseShellExecute = true
            });
        }
        private void btnUsuario_Click(object sender, EventArgs e) { CerrarPaneles(sender); }
        private void btnConfig_Click(object sender, EventArgs e) { CerrarPaneles(sender); }
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
            Panel_Acceso ventana = new Panel_Acceso();
            ventana.RecomendarActivo();
            ventana.Show();
            this.Hide();
        }

        public void IndexarCatalogoTitulares(Catalogo FormHijo, object sender)
        {
            // Da el fondo clarito al boton seleccionado.
            ColorearSeleccion(sender);

            // Si el contendero tiene elementos, los elimina
            if (Contenedor.Controls.Count > 0)
                Contenedor.Controls.RemoveAt(0);

            FormHijo.TopLevel = false; // Indica que no es un formulario de alto nivel, si no subordinado.
            FormHijo.Dock = DockStyle.Fill; // Indica que ocupe todo el espacio.   

            FormHijo.EntrarMayor += AbrirMayor;

            Contenedor.Controls.Add(FormHijo); // Agrega el control al contenedor.
            Contenedor.Tag = FormHijo;
            FormHijo.Show(); // Muestra el panel.
        }
        public void IndexarCatalogoAlmacen(Catalogo FormHijo, object sender)
        {
            // Da el fondo clarito al boton seleccionado.
            ColorearSeleccion(sender);

            // Si el contendero tiene elementos, los elimina
            if (Contenedor.Controls.Count > 0)
                Contenedor.Controls.RemoveAt(0);

            FormHijo.TopLevel = false; // Indica que no es un formulario de alto nivel, si no subordinado.
            FormHijo.Dock = DockStyle.Fill; // Indica que ocupe todo el espacio.   

            FormHijo.EntrarMayor += AbrirAlmacen;

            Contenedor.Controls.Add(FormHijo); // Agrega el control al contenedor.
            Contenedor.Tag = FormHijo;
            FormHijo.Show(); // Muestra el panel.
        }

        private void AbrirMayor(string noTarjeta, Cuentas cuenta)
        {
            string ruta = cuenta == Cuentas.Proveedores ? Rutas.MayoresProveedores : Rutas.MayoresClientes;
            string raiz = cuenta == Cuentas.Proveedores ? Raices.MayoresProveedores : Raices.MayoresClientes;

            // Cargamos el archivo correspondiente.
            Sistema.VerificarArchivo(ruta, raiz);
            XmlDocument lector = new XmlDocument();
            lector.Load(ruta);

            XmlNode RegMayor = lector.DocumentElement.SelectSingleNode($"mayor[@noTarjeta='{noTarjeta}']");
            Mayor Mayor = ConvertidorXml.ElementoToObjeto<Mayor>((XmlElement)RegMayor);

            Sistema.IndexarFormulario(Contenedor, new EsquemaAuxiliar(Mayor));
        }
        private void AbrirAlmacen(string noTarjeta, Cuentas cuenta)
        {
            Sistema.VerificarArchivo(Rutas.Almacen, Raices.Almacen);
            XmlDocument lector = new XmlDocument();
            lector.Load(Rutas.Almacen);

            XmlNode RegMayor = lector.DocumentElement.SelectSingleNode($"mayor[@noTarjeta='{noTarjeta}']");
            Mayor Mayor = ConvertidorXml.ElementoToObjeto<Mayor>((XmlElement)RegMayor);

            Sistema.IndexarFormulario(Contenedor, new EsquemaAuxiliar(Mayor));
        }
    }
}
