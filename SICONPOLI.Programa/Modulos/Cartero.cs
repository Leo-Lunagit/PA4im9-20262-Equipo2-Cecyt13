using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MimeKit;
using MailKit.Net.Smtp;
using MailKit.Security;
using System.Windows.Forms;

namespace PA4IM9_20262_Equipo2.Modulos
{
    public static class Cartero
    {
        public static async Task EnviarCorreo(Correo Datos)
        {
            MimeMessage Mensaje = new MimeMessage();

            Mensaje.From.Add(new MailboxAddress("SIRETECH Poli", "siretechpoli@gmail.com"));
            if (Datos.Destinatario != null) Mensaje.To.Add(Datos.Destinatario);
            else foreach (MailboxAddress Destinatario in Datos.Destinatarios)
                    Mensaje.To.Add(Destinatario);

            Mensaje.Subject = Datos.Asunto;
            Mensaje.Body = new TextPart("html") { Text = Datos.MensajeHtml };

            using (SmtpClient Cartero = new SmtpClient())
            try
            {
                await Cartero.ConnectAsync("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
                await Cartero.AuthenticateAsync("siretechpoli@gmail.com", "oqoy cpzn nsya gmpg");
                await Cartero.SendAsync(Mensaje);
            }
            catch (Exception ex) { MessageBox.Show("Fallo el envio" + ex); }
            finally { 
                    await Cartero.DisconnectAsync(true);
                    MessageBox.Show("Corre Enviado con exito");
                }
        }
    }

    public class Correo
    {
        public MailboxAddress[] Destinatarios;
        public MailboxAddress Destinatario;
        public string Asunto;
        public string MensajeHtml;
    }
}
