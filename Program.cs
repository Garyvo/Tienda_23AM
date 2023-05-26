using System;
using Prueva.Services;
using Prueva.Entites;

namespace Prueva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Usuario user = new Usuario();
            Operacion op1 = new Operacion();

            double total = op1.compra();
            Console.WriteLine("El monto final de tu compra es de: " + total);
            
            user.mostrar();
        }
    }
}
