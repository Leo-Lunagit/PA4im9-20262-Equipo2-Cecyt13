using Microsoft.Win32;
using PA4IM9_20262_Equipo2.Entidades;
using PA4IM9_20262_Equipo2.Modulos;
using PA4IM9_20262_Equipo2.Vistas.CamposSubCuentas;
using PA4IM9_20262_Equipo2.Vistas.Panel_Principal;
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
using System.Globalization;

namespace PA4IM9_20262_Equipo2.Vistas.PanelVentas
{
    public partial class Panel_Ventas : Form
    {
        private static string[] Conceptos = { "Venta de mercancia.", "Cobro de venta de mercancia." };
        private string ConceptoPorDefecto = Conceptos[0];
        //
        // Logica de carga.
        //
        public Panel_Ventas()
        {
            InitializeComponent();
            CompletarComponentes();
        }

        private void CompletarComponentes()
        {
            // Incrusta los controles del formulario de ventas.
            Sistema.IndexarControles(this.panFormularios, new FormularioVentas());
            XmlDocument lector = new XmlDocument();
            // Asigna el folio corresposndiente.
            txtFolio.Text = Sistema.GenerarID(Rutas.Ventas, Raices.Ventas, 3);
            // Asignando el concepto por defecto.
            txtConcepto.Text = Conceptos[0];

        }
        //
        // Logica de registros
        //
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            VerificarCampos();

            //    // 1. Validar que el campo Cliente no esté vacío
            //    if (string.IsNullOrWhiteSpace(txtCliente.Text))
            //    {
            //        MessageBox.Show("Por favor, ingresa el nombre del cliente.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return;
            //    }
            //    if (string.IsNullOrEmpty(txtFactura.Text))
            //    {
            //        MessageBox.Show("Por favor, ingresa el numero de la factura.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return;
            //    }

            Asiento Registro = AsientoVenta();
            GuardarVenta(Registro);
            MostrarMovimiento(Registro);

            LimpiarFormulario();
        }

        private Asiento AsientoVenta()
        {
            FormularioVentas Formulario = panFormularios.Controls[0] as FormularioVentas;

            int sumaProductos = 0;
            Subcuenta[] Cargos = { new Subcuenta() };
            foreach (CamposProducto Producto in Formulario.ContenedorProductos.Controls)
            {
                // Si estan todos sus campos vacios, no hace nada.
                if (Producto.CampoNulo()) continue;

                string Nombre = $"{Producto.nudCantidad.Value} {Producto.cmbNombreItem.Text} a {Producto.txtCostoUni.Text:C} c/u.";
                decimal monto = decimal.Parse(Producto.txtMonto.Text, NumberStyles.Currency, CultureInfo.CurrentCulture);
                Subcuenta producto = new Subcuenta
                {
                    NombreSubcuenta = Nombre,
                    Monto = (int)(monto * 100)
                };
                sumaProductos += producto.Monto;
                Cargos.Append(producto);
            }
            Cargos = Cargos.Skip(1).ToArray();

            Cuenta Almacen = new Cuenta
            {
                NombreCuenta = Cuentas.Almacen.ToString(),
                Subcuentas = Cargos,
                Monto = sumaProductos
            };

            decimal iva = decimal.Parse(Formulario.txtIVA.Text, NumberStyles.Currency, CultureInfo.CurrentCulture);
            Cuenta IVA = new Cuenta
            {
                NombreCuenta = "IVA por Acreditar",
                Monto = (int)(iva * 100)
            };

            int sumaClientes = 0;
            Subcuenta[] Abonos = { new Subcuenta() };
            foreach (CamposTitular Cliente in Formulario.ContenedorClientes.Controls)
            {
                // Si estan todos sus campos vacios, no hace nada.
                if (Cliente.CampoNulo()) continue;

                string Nombre = $"{Cliente.cmbNombreItem.Text} s/f {Cliente.txtFactura}";
                decimal monto = decimal.Parse(Cliente.txtMonto.Text, NumberStyles.Currency, CultureInfo.CurrentCulture);
                Subcuenta cliente = new Subcuenta
                {
                    NombreSubcuenta = Nombre,
                    Monto = (int)(decimal.Parse(Cliente.txtMonto.Text) * 100)
                };
                sumaClientes += cliente.Monto;
                Abonos.Append(cliente);
            }
            Abonos = Abonos.Skip(1).ToArray();

            Cuenta Clientes = new Cuenta
            {
                NombreCuenta = Cuentas.Clientes.ToString(),
                Subcuentas = Abonos,
                Monto = sumaClientes
            };

            Asiento Registro = new Asiento
            {
                Registrador = Sistema.PerfilActivo.Nombre,
                NoAsiento = txtFolio.Text,
                Fecha = DateTime.Now,
                Cargos = new Cuenta[] { Almacen, IVA },
                SumaCargos = Almacen.Monto + IVA.Monto,
                Abonos = new Cuenta[] { Clientes },
                SumaAbonos = Clientes.Monto,
                Concepto = $"{Acciones.Venta.ToString()}:{txtConcepto.Text}"
            };

            return Registro;
        }

        private void GuardarVenta(Asiento Registro)
        {
            Sistema.VerificarArchivo(Rutas.Ventas, Raices.Ventas);
            XmlDocument escritor = new XmlDocument();
            escritor.Load(Rutas.Ventas);

            // Transformamos la clase en elemento xml.
            XmlElement asiento = ConvertidorXml.ObjetoToElemento(escritor, Registro);

            escritor.DocumentElement.AppendChild(asiento);
            //escritor.Save(Rutas.Ventas);
        }
        private void MostrarMovimiento(Asiento Registro)
        {
            string[] paraAccion = Registro.Concepto.Split(':');
            int Subtotal = Registro.Cargos[0].Monto;
            int IVA = Registro.Cargos[1].Monto;
            int Total = Registro.SumaAbonos;
            TablaMovimientos.Rows.Add
            (
                Registro.Fecha, Registro.NoAsiento, paraAccion[0], $"{(Subtotal / 100):C}", 
                $"{(IVA / 100):C}", $"{(Total / 100):C}", Registro.Registrador
            );
        }

        private void LimpiarFormulario()
        {
            txtFolio.Text = Sistema.GenerarID(Rutas.Ventas, Raices.Ventas, 3);
            cmbOpcionesConcepto.SelectedIndex = 0;

            FormularioVentas Formulario = panFormularios.Controls[0] as FormularioVentas;

            Formulario.txtCostoFinal.Text = "";
            Formulario.txtIVA.Text = "";
            Formulario.txtMontoTotal.Text = "";

            Formulario.ContenedorProductos.Controls.Clear();
            Sistema.IndexarCampos(Formulario, Formulario.ContenedorProductos, new CamposProducto(), Cuentas.Almacen);
            Formulario.ContenedorClientes.Controls.Clear();
            Sistema.IndexarCampos(Formulario, Formulario.ContenedorClientes, new CamposTitular(), Cuentas.Clientes);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
        //    //Verifica que haya una celda seleccionada
        //    if(this.TablaMovimientos.SelectedRows.Count == 1)
        //    {
        //        //carga los datos que hay actualmente en los txt a el datagridview
        //        int filaSeleccionada = TablaMovimientos.CurrentRow.Index;
        //        TablaMovimientos.Rows[filaSeleccionada].Cells[0].Value = DateTime.Now;
        //        TablaMovimientos.Rows[filaSeleccionada].Cells[1].Value = cmbProductos.SelectedItem;
        //        TablaMovimientos.Rows[filaSeleccionada].Cells[2].Value = ((int)nudCantidad.Value) * decimal.Parse(txtCostoUni.Text);
        //        TablaMovimientos.Rows[filaSeleccionada].Cells[3].Value = ((int)nudCantidad.Value) * decimal.Parse(txtCostoUni.Text) * (0.16m);
        //        TablaMovimientos.Rows[filaSeleccionada].Cells[4].Value = ((int)nudCantidad.Value) * decimal.Parse(txtCostoUni.Text) * (1.16m);
        //        TablaMovimientos.Rows[filaSeleccionada].Cells[5].Value = Sistema.PerfilActivo.Usuario;
        //    }
        //    btnPagar.Enabled = false;
        }
        public bool VerificarCampos()
        {
            FormularioVentas formulario = panFormularios.Controls[0] as FormularioVentas;
            bool FormularioCompleto = formulario.CamposCompletos();

            bool Completos = FormularioCompleto && txtConcepto.Text != "";

            if (!Completos)
                MessageBox.Show("Por favor complete los campos vacios", "Campos vacios", MessageBoxButtons.OK);
            return Completos;
        }
        //
        // Logica de utilidades
        //

        // Ultimo para registrar
        private void btnIntercalar_Click(object sender, EventArgs e)
        {
            // Dinamicamente manda a incrustar el formulario adecuado.
            if (btnIntercalar.Text == "COBRAR")
            {
                Sistema.IndexarControles(this.panFormularios, new FormularioCobros());
                btnIntercalar.Text = "VENDER";
                ConceptoPorDefecto = Conceptos[1];
            }
            else
            {
                Sistema.IndexarControles(this.panFormularios, new FormularioVentas());
                btnIntercalar.Text = "COBRAR";
                ConceptoPorDefecto = Conceptos[0];
            }
        }

        private void cmbOpcionesConcepto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOpcionesConcepto.Text == "Por Defecto")
            {
                txtConcepto.Text = ConceptoPorDefecto;
                txtConcepto.ReadOnly = true;
            }
            else
            {
                txtConcepto.Text = "";
                txtConcepto.ReadOnly = false;
                txtConcepto.Focus();
            }
        }
    }
}