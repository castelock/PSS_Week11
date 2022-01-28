using System;
using System.Collections.Generic;
using System.Text;

namespace Week_11
{
    public interface IBebida
    {
        string Nombre { get; set; }
        float Coste();
    }
}
