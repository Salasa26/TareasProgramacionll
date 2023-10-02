using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2._1
{
    internal class Program
    {
        static int Cantidad = 0;
        static double descuento = 0;

        static void Main(string[] args)
        {

            Program.Descuento();


        }

        static void Descuento()
        {

            // Descunto
            Console.WriteLine("Digite la cantidad de camisas que desea comprar:");
            int Cantidad = int.Parse(Console.ReadLine());

            double descuento = 0.85;

            if (Cantidad == 1)
            {
                descuento = 1;
            }

            if (Cantidad > 5)
            {
                descuento = 0.80;
            }

            Console.WriteLine($"Aplica un descuento del : {(1 - descuento) * 100} %");

            // Precios

            Console.WriteLine("Digite los precios ($)");
            int Precio1 = 0;
            
            for (int x = 0; x < Cantidad; x++) 
            {
                
                int Precio = int.Parse(Console.ReadLine());
                Precio = Precio + Precio1;
                Precio1 = Precio;

            }

            Console.WriteLine($"El precio final es de: ${Precio1 * descuento} ");


            Console.ReadLine();
        }



    }
}
