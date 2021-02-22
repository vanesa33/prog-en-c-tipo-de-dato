using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Ejercicio_Propuesto_3
{
    class Program
    {
        static void Main(string[] args)
        {
            char TECLA;
            string linea;
            Console.Write("DIGITE UNA SOLA TECLA");
            Console.WriteLine();
            linea = Console.ReadLine();
            TECLA = char.Parse(linea);
            switch (TECLA)
            {
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    ; Console.WriteLine("ES UNA CIFRA NUMERICA");
                    break;
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    ; Console.WriteLine("ES UNA VOCAL");
                    break;
                default:
                    Console.WriteLine("ES UNA CONSONANTE");
                    break;
            }
            Console.Write("Pulse una Tecla:"); Console.ReadLine();
        }
    }
}