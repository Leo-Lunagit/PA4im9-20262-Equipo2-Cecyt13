using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using PA4IM9_20262_Equipo2.Entidades;

namespace PA4IM9_20262_Equipo2.Modulos
{
    public static class PlantillasCorreo
    {
        private static string[] Deslindados = 
        {
            "<strong>Aviso de seguridad:</strong> Si tú no solicitaste este código o no reconoces esta cuenta de correo, por favor haz caso omiso de este mensaje y elimínalo de inmediato.",
            "<strong>Aviso de seguridad:</strong> Si tú no iniciaste este proceso de recuperación, alguien podría estar intentando acceder a tu cuenta. Te sugerimos verificar la seguridad de tus accesos. Ignora y elimina este correo si fue un error.",
            "<strong>Comprobante Oficial:</strong> Este documento digital constituye un acuse de recibo de reciclaje técnico. Conserve este correo para cualquier aclaración física en los almacenes del CECyT 13."
        };
        private static string LogoVer = @"<img alt='SIRETECH' src='https://github.com/Leo-Lunagit/PA4im9-20262-Equipo2-Cecyt13/blob/main/SICONPOLI.Programa/Recursos/Multimedia/SIRETECH-Ver.png?raw=true' style='width: 170px; max-width: 100%; height: auto; margin-bottom: 15px;'>";
        private static string LogoHor = @"<img alt='SIRETECH' src='https://github.com/Leo-Lunagit/PA4im9-20262-Equipo2-Cecyt13/blob/main/SICONPOLI.Programa/Recursos/Multimedia/SIRETECH-Hor.png?raw=true' style='height: 48px; max-width: 100%; display: block; margin: auto; margin-bottom: 25px;'>";

        private static string Declaracion = @"
<!DOCTYPE html>
<html lang='es'>
<head>
    <meta charset='UTF-8'>
    <meta name='viewport' content='width=device-width, initial-scale=1.0'>
    <title>Código de Verificación - SIRETECH Poli</title>
</head>";
        private static string Header = @"
        <tr>
            <td bgcolor='#6f1d46' style='padding: 10px 15px; text-align: center;'>
                <table width='100%' border='0' cellpadding='0' cellspacing='0'>
                    <tr>
                        <td width='75' align='left'>
                            <img alt='IPN' src='https://onceninasyninos.tv/wp-content/uploads/2018/04/Banner-logos-ipn-e1523046221576.png' style='height: 65px; display: block;'>
                        </td>
                        <td align='center' style='color: #FFFFFF; font-size: 11px; line-height: 14px; padding: 0 10px;'>
                            <strong style='display: block; margin-bottom: 2px; font-size: 12px;'>INSTITUTO POLITÉCNICO NACIONAL</strong>
                            <span style='font-style: italic; opacity: 0.9; display: block; margin-bottom: 2px;'>""La Técnica al Servicio de la Patria""</span>
                            <span style='opacity: 0.8; display: block;'>CECyT 13 ""Ricardo Flores Magón""</span>
                        </td>
                        <td width='75' align='right'>
                            <img alt='CECyT 13' src='https://raw.githubusercontent.com/Leo-Lunagit/PA4im9-20262-Equipo2-Cecyt13/refs/heads/main/SICONPOLI.Programa/Recursos/Multimedia/cecyt13-blanco.png' style='height: 65px; display: block;'>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>

        <tr>
            <td style='padding: 35px 20px; text-align: center;'>";

        private static string Footer(int indice) { return $@"
            </td>
        </tr>
        
        <tr>
            <td bgcolor='#6f1d46' style='padding: 25px 30px; text-align: center; color: #E2E8F0; font-size: 11px; line-height: 16px;'>
                <strong style='color: #F1F9F3; font-size: 13px; display: block; margin-bottom: 5px;'>SIRETECH Poli © {DateTime.Now.Year}</strong>
                <span style='display: block; margin-bottom: 15px; opacity: 0.9;'>Sistema de Gestión de Reciclaje Tecnológico</span>
                <hr style='border: 0; border-top: 1px solid rgba(255, 255, 255, 0.15); margin-bottom: 15px;'>
                <p style='color: #CBD5E0; margin: 0 0 8px 0;'>
                    {Deslindados[indice]}
                <p style='color: #A0AEC0; margin: 0;'>
                    Este es un correo generado automáticamente. Por favor, no respondas a este mensaje.
                </p>
            </td>
        </tr>"; }

        private static string InicioTabla = @"<body style='font-family: ""Gill Sans"", ""Gill Sans MT"", Calibri, ""Trebuchet MS"", sans-serif; margin: 0; padding: 20px; background-color: #F4F6F8;'>
    <table align='center' border='0' cellpadding='0' cellspacing='0' width='100%' style='max-width: 550px; background-color: #ffffff; border-radius: 16px; box-shadow: 0 8px 30px rgba(0,0,0,0.08); overflow: hidden; border: 1px solid #E2E8F0;'>";
        private static string FinTabla = @"</table>
</body>
</html";

        public static string Verificacion(PaqueteVerificacion Paquete)
        {
            return $@"
{Declaracion}
{InicioTabla}
        {Header}
                {LogoVer}
                
                <h1 style='color: #184725; font-size: 22px; margin: 0 0 15px 0; font-weight: 700;'>
                    ¡Hola, Futuro del Reciclaje!
                </h1>
                
                <p style='color: #4A5568; font-size: 14px; line-height: 20px; margin: 0 0 20px 0;'>
                    Estás a un solo paso de unirte a la red más importante de <strong>Reciclaje Tecnológico en el Politécnico</strong>. Hemos recibido tu solicitud de acceso a la plataforma <strong>SIRETECH Poli</strong>.
                </p>
                
                <p style='color: #718096; font-size: 13px; margin-bottom: 15px;'>
                    Usa el siguiente código de seguridad para verificar tu identidad y activar tu cuenta:
                </p>

                <table align='center' border='0' cellpadding='0' cellspacing='0' style='margin: 10px auto 25px auto;'>
                    <tr>
                        <td align='center' style='background-color: #F1F9F3; border: 2px dashed #5D8E1E; border-radius: 12px; padding: 15px 35px;'>
                            <span style='font-family: ""Courier New"", Courier, monospace; font-size: 32px; font-weight: bold; color: #184725; letter-spacing: 6px; display: block;'>
                                {Paquete.Codigo}
                            </span>
                        </td>
                    </tr>
                </table>

                <p style='color: #A0AEC0; font-size: 11px; margin: 0;'>
                    Este código es confidencial y tiene un tiempo de expiración de 15 minutos. No lo compartas con nadie.
                </p>
            {Footer(PaqueteVerificacion.indice)}
    {FinTabla}";
        }

        public static string Recuperacion(PaqueteRecuperacion Paquete)
        {
            return $@"
{Declaracion}
{InicioTabla}
        {Header}
                {LogoVer}        
                
                <h1 style='color: #184725; font-size: 22px; margin: 0 0 10px 0; font-weight: 700;'>
                    ¿Olvidaste tu contraseña, {Paquete.Nombre}?
                </h1>
                
                <p style='color: #4A5568; font-size: 14px; line-height: 20px; margin: 0 0 20px 0;'>
                    No te preocupes, a cualquiera le pasa. Hemos recibido una solicitud para restablecer las credenciales de acceso de tu cuenta en <strong>SIRETECH Poli</strong>.
                </p>

                <table align='center' border='0' cellpadding='0' cellspacing='0' style='background-color: #F8FAFC; border-radius: 8px; width: 100%; max-width: 400px; margin-bottom: 20px; border: 1px solid #EDF2F7;'>
                    <tr>
                        <td style='padding: 10px 15px; text-align: left; font-size: 12px; color: #718096; line-height: 18px;'>
                            <strong>Usuario:</strong> {Paquete.Usuario}<br>
                            <strong>Solicitado desde:</strong> <span style='color: #4A5568; font-family: monospace;'>{Paquete.Correo}</span>
                        </td>
                    </tr>
                </table>
                
                <p style='color: #718096; font-size: 13px; margin-bottom: 15px;'>
                    Ingresa este código de seguridad temporal en la aplicación para restablecer tu contraseña:
                </p>

                <table align='center' border='0' cellpadding='0' cellspacing='0' style='margin: 10px auto 25px auto;'>
                    <tr>
                        <td align='center' style='background-color: #F1F9F3; border: 2px dashed #5D8E1E; border-radius: 12px; padding: 15px 35px;'>
                            <span style='font-family: ""Courier New"", Courier, monospace; font-size: 32px; font-weight: bold; color: #184725; letter-spacing: 6px; display: block;'>
                                {Paquete.Contrasenia}
                            </span>
                        </td>
                    </tr>
                </table>

                <p style='color: #A0AEC0; font-size: 11px; margin: 0;'>
                    Por motivos de seguridad, este código es de un solo uso y expirará en 15 minutos.
                </p>
            {Footer(PaqueteRecuperacion.indice)}
    {FinTabla}";
        }
        public static string Producto(PaqueteProducto Paquete)
        {
            return $@"<tr style='border-bottom: 1px solid #EDF2F7; font-family: ""Segoe UI"", ""Gill Sans"", Calibri, sans-serif;'>
                            <td align='left' style='padding: 10px; color: #4A5568;'>{Paquete.Producto}</td>
                            <td align='center' style='color: #4A5568;'>{Paquete.Cantidad}</td>
                            <td align='right' style='font-family: monospace; color: #4A5568;'>{Paquete.Monto:C2}</td>
                        </tr>
                        ";
        }
        public static string Factura(PaqueteFactura Paquete)
        {
            return $@"
{Declaracion}
{InicioTabla}
    {Header}
            {LogoHor}

            <h2 style='color: #184725; font-size: 20px; margin: 0 0 15px 0; text-align: center; font-weight: 700;'>
                    Comprobante de Operación Digital
                </h2>

                <p style='color: #4A5568; font-size: 13px; line-height: 18px; margin: 0 0 20px 0; text-align: center;'>
                    Gracias por contribuir al cuidado ambiental mediante el reciclaje tecnológico ordenado. A continuación, se detallan los datos correspondientes a tu última transacción.
                </p>

                <table align='center' border='0' cellpadding='0' cellspacing='0' style='background-color: #F8FAFC; border-radius: 10px; width: 100%; margin-bottom: 25px; border: 1px solid #EDF2F7;'>
                    <tr>
                        <td style='padding: 15px; font-size: 12px; color: #4A5568; line-height: 20px;'>
                            <table width='100%' border='0' cellpadding='0' cellspacing='0'>
                                <tr>
                                    <td width='50%' style='vertical-align: top; padding-right: 10px;'>
                                        <strong style='color: #184725;'>No. de Folio:</strong> <span style='font-family: monospace; font-weight: bold;'>{Paquete.Factura}</span><br>
                                        <strong>Operador:</strong> {Paquete.Colaborador}<br>
                                        <strong>Destinatario:</strong> {Paquete.Destinatario}
                                    </td>
                                    <td width='50%' style='vertical-align: top; border-left: 1px solid #E2E8F0; padding-left: 15px;'>
                                        <strong>Emisión:</strong> {Paquete.FechaEmision}<br>
                                        <strong>Expiración:</strong> {Paquete.FechaExpiracion}<br>
                                        <strong>Emisor:</strong> {Paquete.Emisor}<br>
                                        <strong>Estado:</strong> <span style='background-color: #DCFCE7; color: #15803D; padding: 2px 6px; border-radius: 4px; font-size: 10px; font-weight: bold;'>Procesado</span>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>

                <table width='100%' border='0' cellpadding='8' cellspacing='0' style='border-collapse: collapse; font-size: 13px; margin-bottom: 20px; border: 1px solid #E2E8F0; border-radius: 8px; overflow: hidden;'>
                    <thead>
                        <tr style='background-color: #F1F9F3; border-bottom: 2px solid #5D8E1E;'>
                            <th align='left' style='color: #184725; font-weight: bold; font-size: 12px; padding: 10px;'>Producto</th>
                            <th align='center' style='color: #184725; font-weight: bold; font-size: 12px; width: 60px;'>Peso. Kg</th>
                            <th align='right' style='color: #184725; font-weight: bold; font-size: 12px; width: 90px; padding: 10px;'>Monto</th>
                        </tr>
                    </thead>
                    <tbody>

                        {Paquete.ProductosHtml}
                    </tbody>
                </table>

                <table align='right' border='0' cellpadding='4' cellspacing='0' style='width: 100%; max-width: 240px; font-size: 13px; color: #4A5568; margin-bottom: 20px;'>
                    <tr>
                        <td align='left'>Subtotal:</td>
                        <td align='right' style='font-family: monospace;'>{Paquete.Subtotal}</td>
                    </tr>
                    <tr>
                        <td align='left'>I.V.A (16%):</td>
                        <td align='right' style='font-family: monospace;'>{Paquete.IVA}</td>
                    </tr>
                    <tr style='border-top: 1px solid #E2E8F0;'>
                        <td align='left' style='font-weight: bold; color: #184725; font-size: 14px; padding-top: 8px;'>Total:</td>
                        <td align='right' style='font-weight: bold; color: #184725; font-size: 15px; font-family: monospace; padding-top: 8px;'>{Paquete.Total}</td>
                    </tr>
                </table>
                
                <div style='clear: both;'></div>
            {Footer(PaqueteFactura.indice)}
        {FinTabla}";
        }
    }
}
