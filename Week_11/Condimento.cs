using System;
using System.Collections.Generic;
using System.Text;
using Week_11;

namespace Drink_Decorator
{
    public abstract class Condimento:IBebida
    {
        protected IBebida Bebida;
        public string Nombre { get; set;}
        public virtual float Coste()
        {
            return 0.0F;
        }

        public Condimento()
        {
            Nombre = "";
        }
    }
}
