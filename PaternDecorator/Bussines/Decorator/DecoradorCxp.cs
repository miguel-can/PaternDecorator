using PaternDecorator.Bussines.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternDecorator.Bussines.Decorator
{
    abstract class DecoradorCxp : IProcesaCxp
    {
        protected IProcesaCxp svrGuardadorCxp;
        public DecoradorCxp(IProcesaCxp _svrGuardadorCxp)
        {
            this.svrGuardadorCxp = _svrGuardadorCxp;
        }

        public virtual void Procesar()
        {
            if (this.svrGuardadorCxp != null)
            {
                this.svrGuardadorCxp.Procesar();
            }           
        }
    }
}
