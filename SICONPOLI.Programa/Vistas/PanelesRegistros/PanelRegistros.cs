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
using PA4IM9_20262_Equipo2.Vistas.FormulariosRegistros;

namespace PA4IM9_20262_Equipo2.Vistas.PanelVentas
{
    public partial class PanelRegistros : Form
    {
        private Cuentas CuentaTitular;
        private static string[] Conceptos = { "Compra de mercancia.", "Pago de compra de mercancia.", "Venta de mercancia.", "Cobro de venta de mercancia."};
        private string ConceptoPorDefecto;
        private string Ruta;
        private string Raiz;
        //
        // Logica de carga.
        //
        public PanelRegistros(Cuentas cuentaTitular)
        {
            InitializeComponent();
            CompletarComponentes(cuentaTitular);
            CargarMovimientos();
        }

        private void CompletarComponentes(Cuentas cuenta)
        {
            CuentaTitular = cuenta;
            bool EsVentas = CuentaTitular == Cuentas.Clientes;
            
            ConceptoPorDefecto = EsVentas ? Conceptos[2] : Conceptos[0];
            Ruta = EsVentas ? Rutas.Ventas : Rutas.Compras;
            Raiz = EsVentas ? Raices.Ventas : Raices.Compras;

            // Incrusta los controles del formulario correspondiente.
            Sistema.IndexarControles(this.panFormularios, new FormularioFacturaciones(CuentaTitular));
            // Asigna el folio corresposndiente.
            txtFolio.Text = Sistema.GenerarID(Ruta, Raiz, 3);
            // Asignando el concepto por defecto.
            txtConcepto.Text = ConceptoPorDefecto;
        }

        private void CargarMovimientos()
        {
            Sistema.VerificarArchivo(Ruta, Raiz);
            XmlDocument lector = new XmlDocument();
            lector.Load(Ruta);

            foreach (XmlElement asiento in lector.DocumentElement.ChildNodes)
            {
                Asiento Registro = ConvertidorXml.ElementoToObjeto<Asiento>(asiento);
                MostrarMovimiento(Registro);
            }
        }
        //
        // Logica de Validaciones
        //
        public bool VerificarCampos()
        {
            bool EsVentas = CuentaTitular == Cuentas.Clientes;
            Formulario formulario = panFormularios.Controls.OfType<Formulario>().First();

            bool FormularioCompleto = formulario.CamposCorrectos();
            bool Completos = FormularioCompleto && txtConcepto.Text != "";

            if (!Completos)
                MessageBox.Show("Por favor complete los campos vacios", "Campos vacios", MessageBoxButtons.OK);
            return Completos;
        }
        //
        // Logica de registros
        //
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (!VerificarCampos()) return;
            
            Asiento Registro = AsientoFacturacion();
            GuardarVenta(Registro);
            MostrarMovimiento(Registro);

            Saldos saldoProducto = CuentaTitular == Cuentas.Proveedores ? Saldos.Deudor : Saldos.Acredor;
            Saldos saldoTitular = CuentaTitular == Cuentas.Proveedores ? Saldos.Acredor : Saldos.Deudor;
            RegistradorMayor.AsientoToAuxiliar(Registro, saldoTitular, CuentaTitular);
            RegistradorMayor.AsientoToAlmacen(Registro, saldoProducto);

            LimpiarFormulario();
        }

        private void GuardarVenta(Asiento Registro)
        {
            Sistema.VerificarArchivo(Ruta, Raiz);
            XmlDocument escritor = new XmlDocument();
            escritor.Load(Ruta);

            // Transformamos la clase en elemento xml.
            XmlElement asiento = ConvertidorXml.ObjetoToElemento(escritor, Registro);

            escritor.DocumentElement.AppendChild(asiento);
            escritor.Save(Ruta);
        }
        private void MostrarMovimiento(Asiento Registro)
        {
            bool EsCompra = CuentaTitular == Cuentas.Proveedores;

            string[] paraAccion = Registro.Concepto.Split(':');
            int Subtotal = EsCompra ? Registro.Cargos[0].Monto : Registro.Abonos[0].Monto;
            int IVA = EsCompra ? Registro.Cargos[1].Monto : Registro.Abonos[1].Monto;
            int Total = EsCompra ? Registro.SumaAbonos : Registro.SumaCargos;

            TablaMovimientos.Rows.Add
            (
                Registro.Fecha, Registro.NoAsiento, paraAccion[0], $"{(Subtotal / 100):C}", 
                $"{(IVA / 100):C}", $"{(Total / 100):C}", Registro.Registrador
            );
        }

        private void LimpiarFormulario()
        {
            txtFolio.Text = Sistema.GenerarID(Ruta, Raiz, 3);
            cmbOpcionesConcepto.SelectedIndex = 0;

            Formulario Formulario = panFormularios.Controls.OfType<Formulario>().First();

            Formulario.txtSubTotal.Text = "";
            Formulario.txtIVA.Text = "";
            Formulario.txtMontoTotal.Text = "";

            Formulario.ContenedorRecursos.Controls.Clear();
            Sistema.IndexarCampos(Formulario, Formulario.ContenedorRecursos, new CamposProducto(), Cuentas.Almacen);
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
        
        //
        // Logica de utilidades
        //
        private void btnIntercalar_Click(object sender, EventArgs e)
        {
            bool EsCompra = CuentaTitular == Cuentas.Proveedores;
            // Dinamicamente manda a incrustar el formulario adecuado.
            if (btnIntercalar.Text == "PAGAR" || btnIntercalar.Text == "COBRAR")
            {
                Sistema.IndexarControles(this.panFormularios, new FormularioTransacciones(CuentaTitular));
                btnIntercalar.Text = EsCompra ? "COMPRAR" : "VENDER";
                ConceptoPorDefecto = EsCompra ? Conceptos[1] : Conceptos[3] ;
            }
            else
            {
                Sistema.IndexarControles(this.panFormularios, new FormularioFacturaciones(CuentaTitular));
                btnIntercalar.Text = EsCompra ? "PAGAR" : "COBRAR";
                ConceptoPorDefecto = EsCompra ? Conceptos[0] : Conceptos[2];
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

        //
        // Registro de Asientos.
        //
        private Asiento AsientoFacturacion()
        {
            bool EsCompra = CuentaTitular == Cuentas.Proveedores;
            FormularioFacturaciones Formulario = panFormularios.Controls[0] as FormularioFacturaciones;

            Subcuenta[] Productos = { new Subcuenta() };
            foreach (CamposProducto Producto in Formulario.ContenedorRecursos.Controls)
            {
                // Si estan todos sus campos vacios, no hace nada.
                if (Producto.CampoNulo()) continue;

                string Nombre = $"{Producto.nudCantidad.Value} {Producto.cmbNombreItem.Text} a {decimal.Parse(Producto.txtCostoUni.Text):C} c/u.";
                decimal Monto = decimal.Parse(Producto.txtMonto.Text, NumberStyles.Currency, CultureInfo.CurrentCulture);
                Subcuenta producto = new Subcuenta
                {
                    NombreSubcuenta = Nombre,
                    Monto = (int)(Monto * 100)
                };
                Productos = Productos.Append(producto).ToArray();
            }
            Productos = Productos.Skip(1).ToArray();
            int sumaProductos = (int)(decimal.Parse(Formulario.txtSubTotal.Text, NumberStyles.Currency, CultureInfo.CurrentCulture) * 100);

            Cuenta Almacen = new Cuenta
            {
                NombreCuenta = Cuentas.Almacen.ToString(),
                Subcuentas = Productos,
                Monto = sumaProductos
            };

            decimal iva = decimal.Parse(Formulario.txtIVA.Text, NumberStyles.Currency, CultureInfo.CurrentCulture);
            Cuenta IVA = new Cuenta
            {
                NombreCuenta = EsCompra ? "IVA por Acreditar" : "IVA por Transladar",
                Monto = (int)(iva * 100)
            };


            int sumaTitulares = (int)(decimal.Parse(Formulario.txtMontoTotal.Text, NumberStyles.Currency, CultureInfo.CurrentCulture) * 100);
            Subcuenta Titular = new Subcuenta
            {
                NombreSubcuenta = $"{Formulario.txtTitular} s/f {Formulario.txtFactura}",
                Monto = sumaTitulares
            };
            Cuenta Titulares = new Cuenta
            {
                NombreCuenta = CuentaTitular.ToString(),
                Monto = sumaTitulares,
                Subcuentas = new Subcuenta[] { Titular }
            };

            Asiento Registro = new Asiento
            {
                Registrador = Sistema.PerfilActivo.Nombre,
                NoAsiento = txtFolio.Text,
                Fecha = DateTime.Now,
                Cargos = EsCompra ? new Cuenta[] { Almacen, IVA } : new Cuenta[] { Titulares },
                SumaCargos = EsCompra ? Almacen.Monto + IVA.Monto : Titulares.Monto,
                Abonos = EsCompra ? new Cuenta[] { Titulares } : new Cuenta[] { Almacen, IVA },
                SumaAbonos = EsCompra ? Titulares.Monto : Almacen.Monto + IVA.Monto,
                Concepto = $"{(EsCompra ? Acciones.Compra : Acciones.Venta).ToString()}:{txtConcepto.Text}"
            };

            return Registro;
        }
    }
}