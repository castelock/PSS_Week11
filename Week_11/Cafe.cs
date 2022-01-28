using System;
using System.Collections.Generic;
using System.Text;

namespace Week_11
{
    class Cafe : IBebida
    {
        public string Nombre { get; set; }
        public float Coste() { return 1.2F; }
        public Cafe() { Nombre = "Café"; }


    }
}
