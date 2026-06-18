using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MimeKit;
using MailKit.Net.Smtp;
using MailKit.Security;

namespace PA4IM9_20262_Equipo2.Modulos
{
    public static class Cartero
    {
        public static async Task EnviarCorreo(Correo Datos)
        {
            MimeMessage Mensaje = new MimeMessage();

            Mensaje.From.Add(new MailboxAddress("SIRETECH Poli", "siretechpoli@gmail.com"));
            Mensaje.To.Add(Datos.Destinatario);

            Mensaje.Subject = Datos.Asunto;
            Mensaje.Body = new TextPart("html") { Text = Datos.MensajeHtml };

            using (SmtpClient Cartero = new SmtpClient())
            try
            {
                await Cartero.ConnectAsync("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
                await Cartero.AuthenticateAsync("siretechpoli@gmail.com", "iswe tszu lug t tt dfz");
                await Cartero.SendAsync(Mensaje);
            }
            catch (Exception ex) { Console.Write("Fallo el envio"); }
            finally { await Cartero.DisconnectAsync(true); }
        }
    }

    public class Correo
    {
        public MailboxAddress Destinatario;
        public string Asunto;
        public string Mensaje;
        public string MensajeHtml;
    }
}
