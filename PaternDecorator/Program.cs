using PaternDecorator.Bussines;
using PaternDecorator.Bussines.Decorator;
using PaternDecorator.Bussines.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IProcesaCxp svrProcesarCxp = new GuardadorCxp();

            
            svrProcesarCxp.Procesar();

            Console.WriteLine("Modificación 1");
            GuardadorHistorialCxp svrGuardadorHistorial = new GuardadorHistorialCxp(svrProcesarCxp);
            svrGuardadorHistorial.Procesar();

            Console.WriteLine("Modificación 2");
            NotificadorEmailCxp svrNotificadorEmail = new NotificadorEmailCxp(svrProcesarCxp);
            svrNotificadorEmail.Procesar();

            Console.WriteLine("Modificación 3");
            NotificadorEmailCxp svrBitacoraEmail = new NotificadorEmailCxp(svrGuardadorHistorial);
            svrBitacoraEmail.Procesar();

            Console.Write("Presiona cualquier tecla para salir del programa...");
            Console.ReadKey();

        }
    }
}
