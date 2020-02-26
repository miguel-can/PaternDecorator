using PaternDecorator.Bussines.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternDecorator.Bussines.Decorator
{
    class NotificadorEmailCxp : DecoradorCxp
    {
        public NotificadorEmailCxp(IProcesaCxp svrGuardadorCxp) : base(svrGuardadorCxp) { }

        public override void Procesar()
        {
            base.Procesar();
            Console.WriteLine("Se envía correo a usuario");
        }
    }
}
