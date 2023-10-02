using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2._3
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Program.PrecioUnitario();

        }
        static void PrecioUnitario()
        {
            Console.WriteLine("Digite la cantidad de productos a comprar:");
            int Cantidad = int.Parse(Console.ReadLine());

            int precio_unitario = 15;

            if (Cantidad <= 10)
            {
                precio_unitario = 20;
            }

            Console.WriteLine($"El precio unitario para {Cantidad} articulo/s es de: ${precio_unitario}.");
            Console.WriteLine($"El precio total es de: ${Cantidad * precio_unitario}.");

            Console.ReadLine();

        }


    }
}
