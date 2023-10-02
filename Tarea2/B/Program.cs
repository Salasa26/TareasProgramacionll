using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2._2
{
    internal class Program
    {
        static float[] quiz = new float[3];
        static float[] tarea = new float[3];
        static float[] examen = new float[3];
        static float[] notas = new float[3] ;
        static float promedio = 0;

        static void Main(string[] args)
        {
            SolicitarDatos();        
            Calculopromedioquiz();
            CalculopromedioTarea();
            CalculopromedioExamen();
            CalculoNotaFinal();

            Console.ReadLine(); 
        }

        static void SolicitarDatos()
        {
            Console.WriteLine($"Ingrese la nota de los Quiz:");
            for (int i = 0; i < notas.Length; i++)
            {
                
                quiz[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine($"Ingrese la nota de las tareas:");

            for (int i = 0; i < notas.Length; i++)
            {

                tarea[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine($"Ingrese la nota de los examenes:");

            for (int i = 0; i < notas.Length; i++)
            {

                examen[i] = int.Parse(Console.ReadLine());

            }




        }

        static void Calculopromedioquiz()
        {
            promedio = 0;
            for (int i = 0; i < 3; i++) 
            { 
                promedio += quiz[i];

            }
            promedio /= 3;
            notas [0]= promedio *= 0.25f;
        }

        static void CalculopromedioTarea()
        {
            promedio = 0;
            for (int i = 0; i < 3; i++)
            {
                promedio += tarea[i];

            }
            promedio /= 3;
            notas[1] = promedio *= 0.30f;
        }

        static void CalculopromedioExamen()
        {
            promedio = 0;
            for (int i = 0; i < 3; i++)
            {
                promedio += examen[i];

            }
            promedio /= 3;
            notas[2] = promedio *= 0.45f;
        }

        static void CalculoNotaFinal()
        {
            float sumatoria = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                promedio += quiz[i];
                sumatoria += notas[i];

            }

            if (sumatoria < 50)
            {
                Console.WriteLine($"Reprobado, nota: {sumatoria}");
            }
            else if (sumatoria >= 50 && sumatoria < 70)
            {

                Console.WriteLine($"Aplazado, nota: {sumatoria}");
            } else Console.WriteLine($"Aprobado, nota: {sumatoria}");



            notas[0] = promedio *= 0.25f;
        }


    }
}
