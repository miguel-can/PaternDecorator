using PaternDecorator.Bussines.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternDecorator.Bussines
{
    public class GuardadorCxp : IProcesaCxp
    {
        public void Procesar()
        {
            Console.WriteLine("Se ha guardado la CXP");
        }
    }
}
