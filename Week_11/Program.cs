using Drink_Decorator;
using System;

namespace Week_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("servicio1: ");
            IBebida cafe = new Cafe(); // café
            IBebida azucar = new Azucar(cafe); // café con azúcar
            IBebida servicio1 = new Azucar(azucar); // café con extra de azúcar

            IBebida servicio2 = new Azucar(new Azucar(new Cafe()));

            Console.WriteLine(servicio1.Nombre);
            Console.WriteLine(servicio1.Coste());

        }
    }
}
