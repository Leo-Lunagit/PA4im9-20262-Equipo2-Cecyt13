using PA4IM9_20262_Equipo2.Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace PA4IM9_20262_Equipo2.Modulos
{
    internal static class Sistema
    {
        // Mediante esos codigos se obtiene la ruta de archivos donde se esta ejecutando el programa.
        public static string rutaEjecusion = AppDomain.CurrentDomain.BaseDirectory;
        // Fusiona la ruta de ejecucion con una ruta nueva, regresa dos carpetas a la carpeta donde tenemos todo el codigo, se dirije a la carpeta de "Datos" y al arhivo.
        public static string rutaUsuarios = Path.Combine(rutaEjecusion, "..", "..", "Datos", "Usuarios.xml");
        public static string rutaConfiguracion = Path.Combine(rutaEjecusion, "..", "..", "Datos", "Configuracion.xml");
        public static string rutaCompras = Path.Combine(rutaEjecusion, "..", "..", "Datos", "Compras.xml");
        public static string rutaVentas = Path.Combine(rutaEjecusion, "..", "..", "Datos", "Ventas.xml");
        public static string rutaAlmacen = Path.Combine(rutaEjecusion, "..", "..", "Datos", "Almacen.xml");
        public static string rutaProveedores = Path.Combine(rutaEjecusion, "..", "..", "Datos", "Proveedores.xml");
        public static string raizUsuarios = "usuarios"; // Elemento raiz del archivo.
        public static string raizConfiguracion = "configuracion"; 
        public static string raizCompras = "compras"; 
        public static string raizVentas = "ventas"; 
        public static string raizAlmacen = "almacen"; 
        public static string raizProveedores = "proveedores"; 
        public static string[] Roles = { "administrador", "colaborador", "cliente" };
        public static string RolPredefinido = Roles[2];
        // Variables para guardar los perfiles logueados.
        public static Perfil[] PerfilesLogueados;
        public static Perfil PerfilActivo;
        public static string banderaRecordar = "recordado";

        // Verificacion de la existencia de un archivo XML.
        public static void VerificarArchivo(string ruta, string nombreRaiz)
        {
            // Objeto que puede manejar archivos .xml.
            XmlDocument documento = new XmlDocument();

            // Intenta cargar el archivo contenido en la ruta especificada.
            try { documento.Load(ruta); }
            // En caso de no poder cargar el archivo
            catch {
                // Si existe obtenemos la ruta de la carpeta para poder evaluarla.
                string directorio = Directory.GetParent(ruta)?.FullName;
                // Si no existe la ruta padre del elemento, crea ese directorio (carpeta).
                if (!Directory.Exists(directorio)) Directory.CreateDirectory(directorio);
                // Si no existia el archivo, hay que llenarlo, si ya existia entonces estaba vasio, hay que llenarlo.
                // Se crea un nodo (elemento con mas elementos dentro) con el manejador de archivos xml.
                XmlNode elementoRaiz = documento.CreateElement(nombreRaiz);
                // Se carga el nodo en el archivo que teniamos en el manejador.
                documento.AppendChild(elementoRaiz);
            }

            // Si como primer elemento tiene una delcaracion xml ya no nesesita nada mas
            if (documento.FirstChild is XmlDeclaration)
            {
                // Guarda los cambios en el mismo archivo/ruta.
                // Si no existe el archivo lo crea.
                documento.Save(ruta);
                return;
            }
            // De manera contraria crea una declaracion xml y la agrega al principio del archivo.
            XmlDeclaration declaration = documento.CreateXmlDeclaration("1.0", "UTF-8", "");
            documento.InsertBefore(declaration, documento.FirstChild);

            // Guarda los cambios en el mismo archivo/ruta.
            documento.Save(ruta);
        }

        public static void IniciarArchivos()
        {
            VerificarArchivo(rutaUsuarios, raizUsuarios);
            VerificarArchivo(rutaCompras, raizCompras);
            VerificarArchivo(rutaVentas, raizVentas);
            VerificarArchivo(rutaAlmacen, raizAlmacen);
            VerificarArchivo(rutaProveedores, raizProveedores);
        }

        public static string GenerarID(string Ruta, string Raiz, int Cifras)
        {
            VerificarArchivo(Ruta, Raiz);
            XmlDocument lector = new XmlDocument();
            lector.Load(Ruta);
            // El numero de perfiles mas 1, asegurandose que minimo tenga 3 cifras aunque con 0 a la izquierda (:D3).
            return $"1{(lector.DocumentElement.ChildNodes.Count + 1).ToString($"D{Cifras}")}"; 
        }

        public static void GuardarPerfil(XmlElement usuario)
        {
            string PadreUsuarios = "usuariosActivos";
            VerificarArchivo(rutaConfiguracion, raizConfiguracion);
            XmlDocument config = new XmlDocument();
            config.Load(rutaConfiguracion);

            XmlNode perfiles = config.DocumentElement[PadreUsuarios];
            if (perfiles == null)
            {
                XmlElement usuariosActivos = config.CreateElement(PadreUsuarios);
                config.DocumentElement.AppendChild(usuariosActivos);
            }

            XmlNode coincidencia = config.DocumentElement.SelectSingleNode($"//perfil[@id='{usuario.Attributes["id"].Value}']");
            if (coincidencia == null)
            {
                // Guarda el perfil junto a los perfiles antes guardados.
                XmlNode importado = config.ImportNode(usuario, true);
                config.DocumentElement[PadreUsuarios].AppendChild(importado);
            }

            config.Save(rutaConfiguracion);
        }

        public static void CargarPerfil(Perfil PerfilLogueado)
        {
            // Si no hay pefiles lo guarda directo.
            if (PerfilesLogueados == null || PerfilesLogueados.Length == 0)
                // Es nesesario crear un nuevo arreglo y luego reemplazar el actual por el creado.
                PerfilesLogueados = new Perfil[] { PerfilLogueado };
            // Si hay perfiles. Y no existe ningun elemento donde coincidan los ides lo guarda.
            else if (!PerfilesLogueados.Any(perfil => perfil.ID == PerfilLogueado.ID))
                // Guarda el perfil junto a los perfiles antes logueados.
                PerfilesLogueados = PerfilesLogueados.Append(PerfilLogueado).ToArray();

            // Siempre guarda o sobreescibe el perfil logueado como el perfil actual.
            PerfilActivo = PerfilLogueado;
        }

        public static void LimpiarRecordado()
        {
            VerificarArchivo(rutaUsuarios, raizUsuarios);
            XmlDocument escritor = new XmlDocument();
            escritor.Load(rutaUsuarios);

            XmlNode perfilRecordar = escritor.DocumentElement.SelectSingleNode("perfil[@recordado]");
            if (perfilRecordar != null)
                perfilRecordar.Attributes.RemoveNamedItem("recordado");

            escritor.Save(rutaUsuarios);
        } 

        public static void CompraToProveedor(Asiento asiento)
        {
            VerificarArchivo(rutaProveedores, raizProveedores);
            XmlDocument escritor = new XmlDocument();
            escritor.Load(rutaProveedores);

            string textoSubProveedor = asiento.Abonos[0].Subcuentas[0].NombreSubcuenta;
            string[] paraProveedor = textoSubProveedor.Split(new string[] { " s/f" }, StringSplitOptions.None);
            string[] paraFactura = textoSubProveedor.Split(new string[] { "s/f " }, StringSplitOptions.None);

            Movimiento debe = new Movimiento();
            debe.Monto = asiento.SumaAbonos;
            debe.Saldo = ((Saldos)1).ToString();

            RenAuxiliar renglon = new RenAuxiliar();
            renglon.Fecha = asiento.Fecha.ToString("dd/MM");
            renglon.Factura = paraFactura[1];
            renglon.Concepto = "Compra de mercancia.";
            renglon.Movimiento = debe;

            XmlNode proveedorExistente = escritor.DocumentElement.SelectSingleNode($"//Auxiliar[titular='{paraProveedor[0]}']");
            if (proveedorExistente == null)
            {
                renglon.Folio = "1001";
                renglon.MontoSaldo = renglon.Movimiento.Monto;

                MayorAuxiliar proveedorNuevo = new MayorAuxiliar();
                proveedorNuevo.Cuenta = "proveedor";
                proveedorNuevo.NoTargeta = "99";
                proveedorNuevo.Titular = paraProveedor[0];
                proveedorNuevo.RenAuxiliares = new RenAuxiliar[] { renglon };

                XmlElement registro = ConvertidorXml.ObjetoToElemento(escritor, proveedorNuevo);

                escritor.DocumentElement.AppendChild(registro);
                escritor.Save(rutaCompras);
            }
            else
            {
                MayorAuxiliar proveedor = ConvertidorXml.ElementoToObjeto<MayorAuxiliar>((XmlElement)proveedorExistente);

                renglon.Folio = $"1{(proveedor.RenAuxiliares.Length + 1):D3}";
                int sentido = renglon.Movimiento.Saldo == ((Saldos)1).ToString() ? 1 : -1;
                renglon.MontoSaldo = renglon.Movimiento.Monto * sentido + proveedor.RenAuxiliares.Last().MontoSaldo;

                proveedor.RenAuxiliares.Append(renglon).ToArray();

                XmlElement proveedorActualizado = ConvertidorXml.ObjetoToElemento(escritor, proveedor);
                escritor.DocumentElement.ReplaceChild(proveedorActualizado, proveedorExistente);
                escritor.Save(rutaProveedores);
            }
        }
        public static void PagoToProveedor(Asiento asiento)
        {
            VerificarArchivo(rutaProveedores, raizProveedores);
            XmlDocument escritor = new XmlDocument();
            escritor.Load(rutaProveedores);

            string textoSubProveedor = asiento.Abonos[0].Subcuentas[0].NombreSubcuenta;
            string[] paraProveedor = textoSubProveedor.Split(new string[] { " s/f" }, StringSplitOptions.None);
            string[] paraFactura = textoSubProveedor.Split(new string[] { "s/f " }, StringSplitOptions.None);

            XmlNode proveedorGuardado = escritor.DocumentElement.SelectSingleNode($"//Auxiliar[titular='{paraProveedor[0]}']");
            MayorAuxiliar proveedor = ConvertidorXml.ElementoToObjeto<MayorAuxiliar>((XmlElement)proveedorGuardado);

            Movimiento debe = new Movimiento();
            debe.Monto = asiento.Cargos[0].Monto;
            debe.Saldo = ((Saldos)0).ToString();

            RenAuxiliar renglon = new RenAuxiliar();
            renglon.Fecha = asiento.Fecha.ToString("dd/MM");
            renglon.Factura = paraFactura[1];
            renglon.Concepto = "Pago de compra.";
            renglon.Folio = $"1{(proveedor.RenAuxiliares.Length + 1):D3}";
            renglon.Movimiento = debe;
            int sentido = renglon.Movimiento.Saldo == ((Saldos)1).ToString() ? 1 : -1;
            renglon.MontoSaldo = renglon.Movimiento.Monto * sentido + proveedor.RenAuxiliares.Last().MontoSaldo;

            proveedor.RenAuxiliares.Append(renglon).ToArray();

            XmlElement proveedorActualizado = ConvertidorXml.ObjetoToElemento(escritor, proveedor);
            escritor.DocumentElement.ReplaceChild(proveedorActualizado, proveedorGuardado);
            escritor.Save(rutaProveedores);
        }
    }
}
