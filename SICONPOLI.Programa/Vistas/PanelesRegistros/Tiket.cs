using Microsoft.Win32;
using MimeKit;
using PA4IM9_20262_Equipo2.Entidades;
using PA4IM9_20262_Equipo2.Modulos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace PA4IM9_20262_Equipo2.Vistas.PanelesRegistros
{
    public partial class Tiket : Form
    {
        PaqueteFactura Factura;
        MailboxAddress[] Destinatarios;
        string[] Correos;
        string NombreTitular;
        string ruta;
        string raiz;

        public Tiket(Asiento Registro, Cuentas Cuenta)
        {
            InitializeComponent();
            CompletarComponentes(Registro, Cuenta);
        }

        private void CompletarComponentes(Asiento Registro, Cuentas CuentaTitular)
        {
            Correos = new string[0];
            Destinatarios = new MailboxAddress[0];

            bool EsCompra = CuentaTitular == Cuentas.Proveedores;
            ruta = EsCompra ? Rutas.Proveedores : Rutas.Clientes;
            raiz = EsCompra ? Raices.Proveedores : Raices.Clientes;

            Cuenta Almacen = EsCompra ? Registro.Cargos[0] : Registro.Abonos[0];
            Cuenta Titulares = EsCompra ? Registro.Abonos[0] : Registro.Cargos[0];
            string[] paraTitular = Titulares.Subcuentas.First().NombreSubcuenta.Split(new string[] { " s/f " }, StringSplitOptions.None);
            NombreTitular = paraTitular.First();

            string Emisor = EsCompra ? paraTitular.First() : Sistema.NombreEmpresa;
            string Destinatario = EsCompra ? Sistema.NombreEmpresa : paraTitular.First();
            string ProductosHtml = "";
            foreach (Subcuenta Producto in Almacen.Subcuentas)
            {
                PaqueteProducto PaqueteProducto = RegistradorMayor.SubAlmacenToPaquete(Producto);
                Sistema.IndexarControles(null, panProductos, new RenProductos(PaqueteProducto), null, DockStyle.None);
                ProductosHtml += PlantillasCorreo.Producto(PaqueteProducto);
            }

            Factura = new PaqueteFactura
            {
                ProductosHtml = ProductosHtml,
                Factura = paraTitular.Last(),
                Destinatario = Destinatario,
                Emisor = Emisor,
                Colaborador = Registro.Registrador,
                FechaEmision = Registro.Fecha.ToShortDateString(),
                FechaExpiracion = $"{DateTime.DaysInMonth(Registro.Fecha.Year, Registro.Fecha.Month).ToString()}/{Registro.Fecha.Month}/{Registro.Fecha.Year}",
                Subtotal = $"{(Almacen.Monto / 100):C2}",
                IVA = $"{((Titulares.Monto - Almacen.Monto) / 100):C2}",
                Total = $"{Titulares.Monto:C2}"
            };

            txtNoTiket.Text = Factura.Factura;
            txtOperador.Text = Factura.Colaborador;
            txtDestino.Text = Factura.Destinatario;
            txtEmision.Text = Factura.FechaEmision;
            txtExpiracion.Text = Factura.FechaExpiracion;
            txtEmisor.Text = Factura.Emisor;

            txtSubtotal.Text = Factura.Subtotal;
            txtIVA.Text = Factura.IVA;
            txtTotal.Text = Factura.Total;
        }

        private async Task EnviarTiket()
        {
            string CuerpoHtml = PlantillasCorreo.Factura(Factura);
            Correo correo = new Correo
            {
                Destinatarios = Destinatarios,
                Asunto = $"Acuse de Factura {Factura.Factura}",
                MensajeHtml = CuerpoHtml
            };

            await Cartero.EnviarCorreo(correo);
        }

        private async void btnCompartir_Click(object sender, EventArgs e)
        {
            Sistema.VerificarArchivo(ruta, raiz);
            XmlDocument lector = new XmlDocument();
            lector.Load(ruta);

            XmlNode regTitular = lector.DocumentElement.SelectSingleNode($"//paqueteTitular[titular='{NombreTitular}']");
            PaqueteTitular Titular = ConvertidorXml.ElementoToObjeto<PaqueteTitular>((XmlElement)regTitular);
            if (Titular.Contacto == "Sin Aclarar.")
            {
                AgregarCorreo ventana = new AgregarCorreo(Correos, true);
                ventana.ShowDialog();
                Correos = ventana.CorreosAgregados;
            }
            foreach (string correo in Correos)
                Destinatarios = Destinatarios.Append(new MailboxAddress("Cliente", correo)).ToArray();

            await EnviarTiket();
        }

        private void btnAgregarCorreo_Click(object sender, EventArgs e)
        {
            AgregarCorreo ventana = new AgregarCorreo(Correos, true);
            ventana.ShowDialog();
            Correos = ventana.CorreosAgregados;
        }
    }
}
