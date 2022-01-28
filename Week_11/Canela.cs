using System;
using System.Collections.Generic;
using System.Text;
using Week_11;

namespace Drink_Decorator
{
    public class Canela:Condimento
    {
        public override float Coste()
        {
            return Bebida.Coste() + 0.18F;
        }

        public Canela(IBebida bebida)
        {
            this.Bebida = bebida;
            Nombre += this.Bebida.Nombre + "Canela";
        }
    }
}
