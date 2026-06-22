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
using PA4IM9_20262_Equipo2.Vistas.Mayores;
using PA4IM9_20262_Equipo2.Vistas.PanelesRegistros;

namespace PA4IM9_20262_Equipo2.Vistas.PanelVentas
{
    public partial class PanelRegistros : Form
    {
        private Cuentas CuentaTitular;
        private static string[] Conceptos = { "Compra de mercancia.", "Pago de compra de mercancia.", "Venta de mercancia.", "Cobro de venta de mercancia." };
        private string ConceptoPorDefecto;
        private bool EsConceptoCompuesto;
        private bool EsCompra;
        private string Ruta;
        private string Raiz;
        private EnlaceEventos[] Eventos = { new EnlaceEventos {Controlador = "ClickEliminar", Evento = "EntrarEliminar" }};

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
            EsCompra = CuentaTitular == Cuentas.Proveedores;

            ConceptoPorDefecto = EsCompra ? Conceptos[0] : Conceptos[2];
            Ruta = EsCompra ? Rutas.Compras : Rutas.Ventas;
            Raiz = EsCompra ? Raices.Compras : Raices.Ventas;

            // Incrusta los controles del formulario correspondiente.
            IndexarFormulumario(new FormularioFacturaciones(CuentaTitular));
            // Asigna el folio corresposndiente.
            txtFolio.Text = Sistema.GenerarID(Ruta, Raiz, 3);
            // Asignando el concepto por defecto.
            cmbOpcionesConcepto.SelectedIndex = 0;

            if (!EsCompra && MEMORIA.Productos.Length == 0)
            {
                MessageBox.Show("Aun no hay productos que se puedan vender, por favor primero compre mercancia.", "SIN PRODUCTOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Enabled = false;
            }
        }
        private void IndexarFormulumario(Formulario formulario)
        {
            panFormularios.Controls.Clear();
            Sistema.IndexarControles(
                Suscriptor: this,
                Contenedor: this.panFormularios, 
                Dock: DockStyle.Fill,
                enlaces: Eventos,
                ObjControles: formulario
            );
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
            Formulario formulario = panFormularios.Controls.OfType<Formulario>().First();
            if (!formulario.CamposCorrectos()) return false;

            if (txtConcepto.Text == "")
            {
                MessageBox.Show("Por favor complete los campos vacios", "Campos vacios", MessageBoxButtons.OK);
                return false;
            }

            VerificarTitular(formulario.txtTitular.Text);
            return true;
        }
        public void VerificarTitular(string nombre)
        {
            string rutaPaquetes = EsCompra ? Rutas.Proveedores : Rutas.Clientes;
            string raizPaquetes = EsCompra ? Raices.Proveedores : Raices.Clientes;

            // Cargamos el archivo correspondiente.
            Sistema.VerificarArchivo(rutaPaquetes, raizPaquetes);
            XmlDocument lector = new XmlDocument();
            lector.Load(rutaPaquetes);

            XmlNode existente = lector.DocumentElement.SelectSingleNode($"//paqueteTitular[titular='{nombre}']");
            if (existente == null)
            {
                DialogResult resultado = MessageBox.Show("El titular ingresado no ha sido registrado. ¿Quiere registrar el titular ahora mismo?", "Titular NO encontrado.", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (resultado == DialogResult.Yes)
                {
                    AgregarTitular ventana = new AgregarTitular(nombre, CuentaTitular);
                    ventana.ShowDialog();
                }
            }
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

            // Determina si sube (saldo deudor, compra de mercancia) o si baja el almacen (saldo acredor, venta de mercancia).
            Saldos saldoProducto = CuentaTitular == Cuentas.Proveedores ? Saldos.Deudor : Saldos.Acredor;
            // (siempre sube) Determina que daldo dar a las cuentas titulares (para provedor saldo Acredor y para cliente saldo deudor).
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
            string[] paraAccion = Registro.Concepto.Split(':');
            Cuenta Titulares;
            // Determinamos si es para facturar o para pagar.
            if (paraAccion[0] == "Compra" || paraAccion[0] == "Venta")
                // Dinamicamente si es para clientes o provedores.
                Titulares = EsCompra ? Registro.Abonos[0] : Registro.Cargos[0];
            else Titulares = EsCompra ? Registro.Cargos[0] : Registro.Abonos[0];
            string textoTitular = Titulares.Subcuentas[0].NombreSubcuenta;
            string[] paraTitular = textoTitular.Split(new string[] { " s/f " }, StringSplitOptions.None);
            int Total = EsCompra ? Registro.SumaAbonos : Registro.SumaCargos;

            TablaMovimientos.Rows.Add
            (
                Registro.NoAsiento, Registro.Fecha, paraAccion[0], paraTitular[0],
                paraTitular[1], $"{(Total / 100):C}", Registro.Registrador
            );
        }

        private void LimpiarFormulario()
        {
            bool EsDeuda = btnIntercalar.Text == "COBRAR" || btnIntercalar.Text == "PAGAR" ? true : false;
            txtFolio.Text = Sistema.GenerarID(Ruta, Raiz, 3);
            cmbOpcionesConcepto.SelectedIndex = 0;

            Formulario Formulario = panFormularios.Controls.OfType<Formulario>().First();

            Formulario.txtSubTotal.Text = "";
            Formulario.txtIVA.Text = "";
            Formulario.txtMontoTotal.Text = "";
            Formulario.txtTitular.Text = "";
            Formulario.txtFactura.Text = "";
            Formulario.AutoFactura = Formulario.GenerarDigitosFactura(4);
            if (!EsCompra) Formulario.cmbFacturas.SelectedIndex = 0;

            Formulario.ContenedorRecursos.Controls.Clear();
            Cuentas NombreCuenta = EsDeuda ? Cuentas.Almacen : Cuentas.Bancos;
            Campos Campos = EsDeuda ? new CamposProducto(CuentaTitular) : (Campos)((new CamposBancos()));
            Sistema.IndexarCampos(Formulario, Formulario.ContenedorRecursos, Campos, NombreCuenta);
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
            // Dinamicamente manda a incrustar el formulario adecuado.
            if (btnIntercalar.Text == "PAGAR" || btnIntercalar.Text == "COBRAR")
            {
                IndexarFormulumario(new FormularioTransacciones(CuentaTitular));
                btnIntercalar.Text = EsCompra ? "COMPRAR" : "VENDER";
                ConceptoPorDefecto = EsCompra ? Conceptos[1] : Conceptos[3] ;
                
            }
            else
            {
                IndexarFormulumario(new FormularioFacturaciones(CuentaTitular));
                btnIntercalar.Text = EsCompra ? "PAGAR" : "COBRAR";
                ConceptoPorDefecto = EsCompra ? Conceptos[0] : Conceptos[2];
            }
            txtConcepto.Text = ConceptoPorDefecto;
        }

        private void cmbOpcionesConcepto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOpcionesConcepto.Text == "Por Defecto")
            {
                txtConcepto.Text = ConceptoPorDefecto;
                txtConcepto.ReadOnly = true;
                EsConceptoCompuesto = false;
            }
            else if (cmbOpcionesConcepto.Text == "Personalizada")
            {
                txtConcepto.Text = "";
                txtConcepto.ReadOnly = false;
                txtConcepto.Focus();
                EsConceptoCompuesto = false;
            } 
            else
            {
                txtConcepto.Text = "Por Defecto + ";
                txtConcepto.ReadOnly = false;
                txtConcepto.Focus();
                EsConceptoCompuesto = true;
            }
        }

        //
        // Registro de Asientos.
        //
        private Asiento AsientoFacturacion()
        {
            FormularioFacturaciones Formulario = panFormularios.Controls[0] as FormularioFacturaciones;

            Subcuenta[] Productos = new Subcuenta[0];
            foreach (CamposProducto Campos in Formulario.ContenedorRecursos.Controls)
            {
                // Si estan todos sus campos vacios, no hace nada.
                if (Campos.CampoNulo()) continue;
                decimal costoUni;
                try { costoUni = decimal.Parse(Campos.txtCostoUni.Text); }
                catch { costoUni = decimal.Parse(Campos.txtCostoUni.Text, NumberStyles.Currency, CultureInfo.CurrentCulture); }
                string Nombre = $"{Campos.nudCantidad.Value} {Campos.cmbNombreItem.Text} a {(costoUni):C} c/u.";
                decimal Monto = decimal.Parse(Campos.txtMonto.Text, NumberStyles.Currency, CultureInfo.CurrentCulture);
                Subcuenta producto = new Subcuenta
                {
                    NombreSubcuenta = Nombre,
                    Monto = (int)(Monto * 100)
                };
                Productos = Productos.Append(producto).ToArray();
            }
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
                NombreSubcuenta = $"{Formulario.txtTitular.Text} s/f {Formulario.txtFactura.Text}",
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

        //
        // Logica de eventos.
        //

        public delegate void ClickRegreso();
        public event ClickRegreso SolicitarEliminacion;

        public void EntrarEliminar()
        {
            SolicitarEliminacion?.Invoke();
        }

        private void txtConcepto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!EsConceptoCompuesto) return;
            TextBox txt = sender as TextBox;
            e.Handled = true;
            if (txt.SelectionStart >= 14 && !(txt.SelectionStart == 14 && e.KeyChar == (char)Keys.Back))
                e.Handled = false;
        }
    }
}