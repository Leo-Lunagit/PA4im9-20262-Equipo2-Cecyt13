using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PA4IM9_20262_Equipo2.Modulos
{
    public class EnlaceEventos
    {
        public string Controlador { get; set; }
        public string Evento { get; set; }
    }

    public class SuscriptorEventos 
    {
        public static void VincularEventos(EnlaceEventos[] Enlaces, object Suscriptor, object Publicador)
        {
            if (Enlaces == null) return;
            foreach (EnlaceEventos enlace in Enlaces )
            {
                if (enlace == null) continue;

                EventInfo infoEvento = Publicador.GetType().GetEvent(enlace.Controlador);
                if (infoEvento == null) continue;

                MethodInfo infoFuncion = Suscriptor.GetType().GetMethod(enlace.Evento, 
                    BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
                if (infoFuncion == null) continue;

                Delegate Delegado = Delegate.CreateDelegate(infoEvento.EventHandlerType, Suscriptor, infoFuncion);
                infoEvento.AddEventHandler(Publicador, Delegado);
            }
        }
    }
}
