using System;
using System.Collections.Generic;
using System.Text;
using Week_11;

namespace Drink_Decorator
{
    public class Azucar : Condimento
    {
        public override float Coste()
        {
            return Bebida.Coste() + 0.13F;
        }

        public Azucar(IBebida bebida)
        {
            this.Bebida = bebida;
            Nombre += this.Bebida.Nombre + "Azúcar";
        }
    }
}
