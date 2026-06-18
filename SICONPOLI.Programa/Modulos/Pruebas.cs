using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MimeKit;

namespace PA4IM9_20262_Equipo2.Modulos
{
    public class Pruebas
    {
        public async Task Iniciar()
        {
            Correo correo = new Correo
            {
                Destinatario = new MailboxAddress("Rodriguez Luna", "rodriguezlunaleonardo13@gmail.com"),
                Asunto = "Prueba",
                MensajeHtml = "VEamos si cala." 
            };

            await Cartero.EnviarCorreo(correo);
        }
    }
}
