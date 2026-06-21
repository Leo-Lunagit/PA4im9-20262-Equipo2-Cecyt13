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
        EnlaceEventos[] EventosBasicos;
        EnlaceEventos[] EventosCatalogo;
        EnlaceEventos[] EventosEsquemas;

        //
        // Logica de carga.
        //
        public MenuPrincipal()
        {
            InitializeComponent();
            CompletarComponentes();
        }

        private void CompletarComponentes()
        {
            EventosBasicos =  new EnlaceEventos[] { new EnlaceEventos {Controlador = "SolicitarEliminacion", Evento = "CerrarPaneles" } };
            EventosCatalogo = EventosBasicos.Append(new EnlaceEventos { Controlador = "EntrarMayor", Evento = "AbrirMayor" }).ToArray();
            EventosEsquemas = new EnlaceEventos[] { new EnlaceEventos { Controlador = "SolicitarRegresar", Evento = "AbrirCatalogo" } };
        }
        private void MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e) { Application.Exit(); }

        //
        // Logica de ventanas.
        //
        private void CerrarPaneles()
        {
            ColorearSeleccion(null);
            // Si el contendero tiene elementos, los elimina
            if (this.Contenedor.Controls.Count > 0)
                this.Contenedor.Controls.RemoveAt(0);

            // Agrega (hace aparecer) el picture box con el logo.
            this.Contenedor.Controls.Add(this.marcaAgua);
        }
        private void AbrirPaneles(Form formularioHijo, EnlaceEventos[] eventos, object sender)
        {
            // Da el fondo clarito al boton seleccionado.
            ColorearSeleccion(sender);

            // Incrusta el formulario en el panel.
            Sistema.IndexarFormulario(
                Suscriptor: this,
                Contenedor: this.Contenedor, 
                ObjFormHijo: formularioHijo, 
                enlaces: eventos
            );
        }
        private void ColorearSeleccion(object sender)
        {
            Button botonColoreado = this.BarraLateral.Controls.OfType<Button>().FirstOrDefault(btn => btn.BackColor == Color.FromArgb(200, 220, 215));
            if (botonColoreado != null) 
                botonColoreado.BackColor = Color.White;

            if (sender == null) return;
            
            Button boton = sender as Button;
            boton.BackColor = Color.FromArgb(200, 220, 215);
        }
        private void AbrirCatalogo(Cuentas Cuenta, object sender)
        {
            AbrirPaneles(
                formularioHijo: new Catalogo(Cuenta),
                eventos: EventosCatalogo,
                sender: sender
            );
        }

        //
        // Ventanas de Botones.
        //
        private void btnHome_Click(object sender, EventArgs e) 
        {
            CerrarPaneles(); 
            ColorearSeleccion(sender);
        }
        private void btnEntradas_Click(object sender, EventArgs e) 
        { 
            AbrirPaneles(
                formularioHijo: new PanelRegistros(Cuentas.Proveedores), 
                sender: sender, 
                eventos: EventosBasicos
            ); 
        }
        private void btnSalidas_Click(object sender, EventArgs e) 
        { 
            AbrirPaneles(
                formularioHijo: new PanelRegistros(Cuentas.Clientes), 
                sender: sender, 
                eventos: EventosBasicos
            ); 
        }
        private void btnClientes_Click(object sender, EventArgs e) { AbrirCatalogo(Cuentas.Clientes, sender); }
        private void btnProvedores_Click(object sender, EventArgs e) { AbrirCatalogo(Cuentas.Proveedores, sender); }
        private void btnAlmacen_Click(object sender, EventArgs e) { AbrirCatalogo(Cuentas.Almacen, sender); }
        private void btnSucursales_Click(object sender, EventArgs e) 
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.google.com/maps/search/recicaldora+de+electronicos+coyoacan/@19.3728181,-99.1949944,15z?entry=ttu&g_ep=EgoyMDI2MDYxNi4wIKXMDSoASAFQAw%3D%3D",
                UseShellExecute = true
            });
        }

        //
        // Botones Desplegables.
        //
        private void btnUsuario_Click(object sender, EventArgs e) 
        { 
            CerrarPaneles(); 
        }
        private void btnConfig_Click(object sender, EventArgs e) 
        { 
            CerrarPaneles(); 
        }

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

        //
        // Metodos de eventos.
        //
        private void AbrirMayor(string noTarjeta, Cuentas cuenta)
        {
            if (cuenta == Cuentas.Almacen)
            {
                AbrirAlmacen(noTarjeta);
                return;
            }

            string ruta = cuenta == Cuentas.Proveedores ? Rutas.MayoresProveedores : Rutas.MayoresClientes;
            string raiz = cuenta == Cuentas.Proveedores ? Raices.MayoresProveedores : Raices.MayoresClientes;

            // Cargamos el archivo correspondiente.
            Sistema.VerificarArchivo(ruta, raiz);
            XmlDocument lector = new XmlDocument();
            lector.Load(ruta);

            XmlNode RegMayor = lector.DocumentElement.SelectSingleNode($"mayor[@noTarjeta='{noTarjeta}']");
            Mayor Mayor = ConvertidorXml.ElementoToObjeto<Mayor>((XmlElement)RegMayor);

            Sistema.IndexarFormulario(
                Suscriptor: this,
                Contenedor: Contenedor, 
                ObjFormHijo: new EsquemaAuxiliar(Mayor),
                enlaces: EventosEsquemas
            );
        }
        private void AbrirAlmacen(string noTarjeta)
        {
            Sistema.VerificarArchivo(Rutas.Almacen, Raices.Almacen);
            XmlDocument lector = new XmlDocument();
            lector.Load(Rutas.Almacen);

            XmlNode RegMayor = lector.DocumentElement.SelectSingleNode($"almacen[@noTarjeta='{noTarjeta}']");
            Almacen Almacen = ConvertidorXml.ElementoToObjeto<Almacen>((XmlElement)RegMayor);

            Sistema.IndexarFormulario(
                Contenedor: Contenedor, 
                ObjFormHijo: new TarjetaAlmacen(Almacen),
                Suscriptor: this,
                enlaces: EventosEsquemas
            );
        }
    }
}
