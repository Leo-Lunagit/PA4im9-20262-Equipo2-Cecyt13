using PA4IM9_20262_Equipo2.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PA4IM9_20262_Equipo2.Modulos
{
    internal class RegistradorProveedores
    {

        public static void CompraToProveedor(Asiento asiento, Saldos saldo)
        {
            Sistema.VerificarArchivo(Rutas.Proveedores, Raices.Proveedores);
            XmlDocument escritor = new XmlDocument();
            escritor.Load(Rutas.Proveedores);

            Cuenta Proveedores = saldo == (Saldos)2 ? asiento.Abonos[0] : asiento.Cargos[0];

            // Para cada proveedor registrado
            foreach (Subcuenta ProveedorRegistrar in Proveedores.Subcuentas)
            {

                // De la subcuenta del proveedor obtenemos al proveedor y la factura.
                string textoSubProveedor = ProveedorRegistrar.NombreSubcuenta;
                // Con base en la cadena ' s/f ' dividimos en dos, una de la cadena hacia atras (donde esta el proveedor)
                // y otra de la cadena hacia adelante (donde esta la factura).
                string[] paraProveedor = textoSubProveedor.Split(new string[] { " s/f" }, StringSplitOptions.None);
                string[] paraFactura = textoSubProveedor.Split(new string[] { "s/f " }, StringSplitOptions.None);

                // Creamos el movimiento que forzosamente debe ser acredor y debe sumarse.
                Movimiento debe = new Movimiento();
                debe.Monto = ProveedorRegistrar.Monto;  
                debe.Saldo = ((Saldos)1).ToString();

                // Creamos el renglon del mayor auxiliar con los datos que si disponemos.
                RenAuxiliar renglon = new RenAuxiliar();
                renglon.Fecha = asiento.Fecha.ToString("dd/MM");
                renglon.Factura = paraFactura[1];
                renglon.Concepto = "Compra de mercancia.";
                renglon.Movimiento = debe;

                // Verificamos si es un nuevo proveedor o si ya existia.
                XmlNode proveedorExistente = escritor.DocumentElement.SelectSingleNode($"//auxiliar[@titular='{paraProveedor[0]}']");
                if (proveedorExistente == null)
                {
                    // Se asignan las propiedades iniciales.
                    renglon.Folio = "1001";
                    renglon.MontoSaldo = renglon.Movimiento.Monto;

                    // Asignamos las propiedades fundamentales de la targeta y el primer reenglon auxiliar.
                    MayorAuxiliar proveedorNuevo = new MayorAuxiliar();
                    proveedorNuevo.Cuenta = "proveedor";
                    proveedorNuevo.NoTargeta = "99";
                    proveedorNuevo.Titular = paraProveedor[0];
                    proveedorNuevo.RenAuxiliares = new RenAuxiliar[] { renglon };

                    // Convertimos el objeto en elemento.
                    XmlElement registro = ConvertidorXml.ObjetoToElemento(escritor, proveedorNuevo);

                    // Lo guardamos en el siguiente espacio.
                    escritor.DocumentElement.AppendChild(registro);
                    escritor.Save(Rutas.Compras);
                }
                else // Si ya existia el registro del proveedor.
                {
                    // Convertir el registro en un objeto de mayor auxiliar.
                    MayorAuxiliar Proveedor = ConvertidorXml.ElementoToObjeto<MayorAuxiliar>((XmlElement)proveedorExistente);

                    int sentido = saldo == (Saldos)2 ? 1 : -1;

                    // Asignamos con respecto a los registros anteriores los datos consecutivos.
                    renglon.Folio = $"1{(Proveedor.RenAuxiliares.Length + 1):D3}";
                    renglon.MontoSaldo = Proveedor.RenAuxiliares.Last().MontoSaldo + renglon.Movimiento.Monto * sentido;

                    // Agregamos el renglon a la siguiente posicion de los reenglones.
                    Proveedor.RenAuxiliares = Proveedor.RenAuxiliares.Append(renglon).ToArray();

                    // Lo reeconvertimos a elemento Xml.
                    XmlElement proveedorActualizado = ConvertidorXml.ObjetoToElemento(escritor, Proveedor);
                    // Reemplazamos el objeto obtenido al principio (sin modificar) por el que modificamos.
                    escritor.DocumentElement.ReplaceChild(proveedorActualizado, proveedorExistente);
                    escritor.Save(Rutas.Proveedores); // Guardamos.
                }

            }
        }
    }
}
