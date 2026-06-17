using PA4IM9_20262_Equipo2.Entidades;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;

namespace PA4IM9_20262_Equipo2.Modulos
{
    internal class RegistradorMayor
    {
        public static void AsientoToAuxiliar(Asiento asiento, Saldos saldo, Cuentas cuenta)
        {
            // Dinamicamente obtenemos la ruta y raiz del archivo correspondiente.
            string ruta = cuenta == Cuentas.Clientes ? Rutas.Clientes : Rutas.Proveedores;
            string raiz = cuenta == Cuentas.Clientes ? Raices.Clientes : Raices.Proveedores;

            // Cargamos el archivo correspondiente.
            Sistema.VerificarArchivo(ruta, raiz);
            XmlDocument escritor = new XmlDocument(); 
            escritor.Load(ruta);

            Cuenta Titulares; // La cuenta que contiene las subcuentas.
            string operacion;
            // Dinamicamente obtenemos los contenedores de las subcuentas.
            // Dinamicame determinamos que operacion se realiza para mostrarla en el concepto.
            if (cuenta == Cuentas.Clientes)
            {
                Titulares = saldo == Saldos.Deudor ? asiento.Cargos[0] : asiento.Abonos[0];
                operacion = saldo == Saldos.Deudor ? Acciones.Venta.ToString() : Acciones.Cobro.ToString();
            }
            else {
                Titulares = saldo == Saldos.Acredor ? asiento.Abonos[0] : asiento.Cargos[0];
                operacion = saldo == Saldos.Acredor ? Acciones.Compra.ToString() : Acciones.Pago.ToString(); 
            }   

            // Para cada proveedor registrado
            foreach (Subcuenta Titular in Titulares.Subcuentas)
            {

                // De la subcuenta obtenemos al titular y la factura.
                string textoSubcuenta = Titular.NombreSubcuenta;
                // Con base en la cadena ' s/f ' dividimos en dos, una de la cadena hacia atras (donde esta el proveedor)
                // y otra de la cadena hacia adelante (donde esta la factura).
                string[] paraDatos = textoSubcuenta.Split(new string[] { " s/f " }, StringSplitOptions.None);

                // Creamos el movimiento que forzosamente debe ser acredor y debe sumarse.
                Movimiento movimiento = new Movimiento
                {
                    Monto = Titular.Monto,
                    Saldo = saldo.ToString()
                };

                // Creamos el renglon del mayor auxiliar con los datos que si disponemos.
                RenMayor renglon = new RenMayor
                {
                    Fecha = asiento.Fecha.ToString("dd/MM"),
                    Factura = paraDatos[1],
                    Concepto = $"{operacion} de mercancia.",
                    Movimiento = movimiento,
                };

                // Verificamos si es un nuevo proveedor o si ya existia.
                XmlNode titularExistente = escritor.DocumentElement.SelectSingleNode($"//mayor[titular='{paraDatos[0]}']");
                if (titularExistente == null)
                {
                    // Se asignan las propiedades iniciales.
                    renglon.Folio = "1001";
                    renglon.MontoSaldo = renglon.Movimiento.Monto;

                    // Asignamos las propiedades fundamentales de la targeta y el primer reenglon auxiliar.
                    Mayor titularNuevo = new Mayor
                    {
                        Cuenta = cuenta.ToString(),
                        NoTargeta = Sistema.GenerarID(ruta, raiz, 3),
                        Titular = paraDatos[0],
                        RenMayores = new RenMayor[] { renglon }
                    };

                    // Convertimos el objeto en elemento.
                    XmlElement registro = ConvertidorXml.ObjetoToElemento(escritor, titularNuevo);

                    // Lo guardamos en el siguiente espacio.
                    escritor.DocumentElement.AppendChild(registro);
                }
                else // Si ya existia el registro del proveedor.
                {
                    // Convertir el registro en un objeto de mayor auxiliar.
                    Mayor MayorTitular = ConvertidorXml.ElementoToObjeto<Mayor>((XmlElement)titularExistente);

                    // Dinamicame determinamos si el movimiento se debe sumar o restal al saldo anterior.
                    int sentido;
                    if (cuenta == Cuentas.Clientes)
                        sentido = saldo == Saldos.Deudor ? 1 : -1 ;
                    else sentido = saldo == Saldos.Acredor ? 1 : -1;

                    // Asignamos con respecto a los registros anteriores los datos consecutivos.
                    renglon.Folio = $"1{(MayorTitular.RenMayores.Length + 1):D3}";
                    renglon.MontoSaldo = MayorTitular.RenMayores.Last().MontoSaldo + renglon.Movimiento.Monto * sentido;

                    // Agregamos el renglon a la siguiente posicion de los reenglones.
                    MayorTitular.RenMayores = MayorTitular.RenMayores.Append(renglon).ToArray();

                    // Lo reeconvertimos a elemento Xml.
                    XmlElement titularActualizado = ConvertidorXml.ObjetoToElemento(escritor, Titular);
                    // Reemplazamos el objeto obtenido al principio (sin modificar) por el que modificamos.
                    escritor.DocumentElement.ReplaceChild(titularActualizado, titularExistente);
                }
            }
            escritor.Save(ruta); // Guardamos.
        }

        public static void AsientoToAlmacen(Asiento asiento, Saldos saldo)
        {
            Sistema.VerificarArchivo(Rutas.Almacen, Raices.Almacen);
            XmlDocument lector = new XmlDocument();
            lector.Load(Rutas.Almacen);

            Cuenta Almacen = saldo == Saldos.Deudor ? asiento.Cargos[0] : asiento.Abonos[0] ;
            Cuenta Titulares = saldo == Saldos.Deudor ? asiento.Abonos[0] : asiento.Cargos[0];
            string[] paraFactura = Titulares.Subcuentas[0].NombreSubcuenta.Split(new string[] { " s/f " }, StringSplitOptions.None);

            foreach  (Subcuenta SubAlmacen in Almacen.Subcuentas)
            {
                string texto = SubAlmacen.NombreSubcuenta;
                string[] ParaCantida = texto.Split(' ');
                // Fragmenta la cadena con el texto escrito por nosotos (" a ");
                string[] ParaCosto = texto.Split(new string[] { " a " }, StringSplitOptions.None);
                // Asegurandonos que sea el texto que nosotros agregamos (hasta el final) quitamos el segundo texto que agregamos (" c/u.)
                string textoCosto = ParaCosto[ParaCosto.Length - 1].Replace(" c/u.", string.Empty);
                // No se que signifique pero funciona me lo genero gemini.
                // Con expreciones regulares (mediante simbolos indica un formato de texto) quita la cantidad y el precio.
                Match match = Regex.Match(texto, @"\d+ (.+) a \d+ c/u\.");
                string nombreProducto = match.Groups[1].Value;

                Movimiento MovInventario = new Movimiento
                {
                    Saldo = saldo.ToString(),
                    Monto = int.Parse(ParaCantida[0])
                };

                Movimiento MovValor = new Movimiento
                {
                    Saldo = saldo.ToString(),
                    Monto = saldo == Saldos.Acredor ? Almacen.Monto / (1 + Sistema.PorcentajeUtilida) : Almacen.Monto
                };

                // Asignamos los datos que ya conocemos.
                RenAlmacen renAlmacen = new RenAlmacen
                {
                    Fecha = asiento.Fecha.ToShortDateString(),
                    Factura = paraFactura[paraFactura.Length - 1],
                    MovInventario = MovInventario,
                    CostoUnitario = int.Parse(textoCosto, NumberStyles.Currency, CultureInfo.CurrentCulture) * 100,
                    MovValor = MovValor
                };

                XmlNode ProductoExistente = lector.DocumentElement.SelectSingleNode($"//almacen[producto='{nombreProducto}']");
                if (ProductoExistente == null)
                {
                    renAlmacen.Folio = "1001";
                    renAlmacen.Existencia = MovInventario.Monto;
                    renAlmacen.CostoPromedio = renAlmacen.CostoUnitario;
                    renAlmacen.MontoSaldo = Almacen.Monto;

                    Almacen NuevoProducto = new Almacen
                    {
                        NoTarjeta = Sistema.GenerarID(Rutas.Almacen, Raices.Almacen, 3),
                        Producto = nombreProducto,
                        CostoUnitario = renAlmacen.CostoPromedio,
                        RenAlmacens = new RenAlmacen[] { renAlmacen }
                    };

                    XmlElement RegistroProducto = ConvertidorXml.ObjetoToElemento(lector, NuevoProducto);
                    lector.DocumentElement.AppendChild(RegistroProducto);
                }
                else
                {
                    int sentido = saldo == Saldos.Deudor ? 1 : -1;
                    Almacen Producto = ConvertidorXml.ElementoToObjeto<Almacen>((XmlElement)ProductoExistente);

                    renAlmacen.Folio = $"1{(Producto.RenAlmacens.Length + 1):D3}";
                    renAlmacen.Existencia += renAlmacen.MovInventario.Monto * sentido;
                    renAlmacen.MontoSaldo += renAlmacen.MovValor.Monto * sentido;
                    renAlmacen.CostoPromedio = renAlmacen.MontoSaldo / renAlmacen.Existencia;

                    Producto.RenAlmacens = Producto.RenAlmacens.Append(renAlmacen).ToArray();

                    XmlElement ProductoModificado = ConvertidorXml.ObjetoToElemento(lector, Producto);
                    lector.DocumentElement.ReplaceChild(ProductoModificado, ProductoExistente);
                }
            }
            lector.Save(Rutas.Almacen);
        }
    }
}
