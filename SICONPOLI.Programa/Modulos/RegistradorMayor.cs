using PA4IM9_20262_Equipo2.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

            Cuenta CuentaContenedora; // La cuenta que contiene las subcuentas.
            // Dinamicamente obtenemos los contenedores de las subcuentas.
            if (cuenta == Cuentas.Clientes)
                CuentaContenedora = saldo == Saldos.Deudor ? asiento.Cargos[0] : asiento.Abonos[0];
            else CuentaContenedora = saldo == Saldos.Acredor ? asiento.Abonos[0] : asiento.Cargos[0];

            // Dinamicame determinamos que operacion se realiza para mostrarla en el concepto.
            string operacion;
            if (cuenta == Cuentas.Clientes)
                operacion = saldo == Saldos.Deudor ? Acciones.Venta.ToString() : Acciones.Cobro.ToString();
            else operacion = saldo == Saldos.Acredor ? Acciones.Compra.ToString() : Acciones.Pago.ToString();

            // Para cada proveedor registrado
            foreach (Subcuenta Subcuenta in CuentaContenedora.Subcuentas)
            {

                // De la subcuenta obtenemos al titular y la factura.
                string textoSubcuenta = Subcuenta.NombreSubcuenta;
                // Con base en la cadena ' s/f ' dividimos en dos, una de la cadena hacia atras (donde esta el proveedor)
                // y otra de la cadena hacia adelante (donde esta la factura).
                string[] paraTitular = textoSubcuenta.Split(new string[] { " s/f" }, StringSplitOptions.None);
                string[] paraFactura = textoSubcuenta.Split(new string[] { "s/f " }, StringSplitOptions.None);

                // Creamos el movimiento que forzosamente debe ser acredor y debe sumarse.
                Movimiento movimiento = new Movimiento
                {
                    Monto = Subcuenta.Monto,
                    Saldo = saldo.ToString()
                };

                // Creamos el renglon del mayor auxiliar con los datos que si disponemos.
                RenMayor renglon = new RenMayor
                {
                    Fecha = asiento.Fecha.ToString("dd/MM"),
                    Factura = paraFactura[1],
                    Concepto = $"{operacion} de mercancia.",
                    Movimiento = movimiento,
                };

                // Verificamos si es un nuevo proveedor o si ya existia.
                XmlNode titularExistente = escritor.DocumentElement.SelectSingleNode($"//auxiliar[@titular='{paraTitular[0]}']");
                if (titularExistente == null)
                {
                    // Se asignan las propiedades iniciales.
                    renglon.Folio = "1001";
                    renglon.MontoSaldo = renglon.Movimiento.Monto;

                    // Asignamos las propiedades fundamentales de la targeta y el primer reenglon auxiliar.
                    Mayor titularNuevo = new Mayor
                    {
                        Cuenta = "proveedor",
                        NoTargeta = "99",
                        Titular = paraTitular[0],
                        RenMayores = new RenMayor[] { renglon }
                    };

                    // Convertimos el objeto en elemento.
                    XmlElement registro = ConvertidorXml.ObjetoToElemento(escritor, titularNuevo);

                    // Lo guardamos en el siguiente espacio.
                    escritor.DocumentElement.AppendChild(registro);
                    escritor.Save(ruta);
                }
                else // Si ya existia el registro del proveedor.
                {
                    // Convertir el registro en un objeto de mayor auxiliar.
                    Mayor Titular = ConvertidorXml.ElementoToObjeto<Mayor>((XmlElement)titularExistente);

                    // Dinamicame determinamos si el movimiento se debe sumar o restal al saldo anterior.
                    int sentido;
                    if (cuenta == Cuentas.Clientes)
                        sentido = saldo == Saldos.Deudor ? 1 : -1 ;
                    else sentido = saldo == Saldos.Acredor ? 1 : -1;

                    // Asignamos con respecto a los registros anteriores los datos consecutivos.
                    renglon.Folio = $"1{(Titular.RenMayores.Length + 1):D3}";
                    renglon.MontoSaldo = Titular.RenMayores.Last().MontoSaldo + renglon.Movimiento.Monto * sentido;

                    // Agregamos el renglon a la siguiente posicion de los reenglones.
                    Titular.RenMayores = Titular.RenMayores.Append(renglon).ToArray();

                    // Lo reeconvertimos a elemento Xml.
                    XmlElement titularActualizado = ConvertidorXml.ObjetoToElemento(escritor, Titular);
                    // Reemplazamos el objeto obtenido al principio (sin modificar) por el que modificamos.
                    escritor.DocumentElement.ReplaceChild(titularActualizado, titularExistente);
                    escritor.Save(ruta); // Guardamos.
                }
            }
        }
    }
}
