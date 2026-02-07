using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaraciones
            float a, b;
            float c = 0;
            int op;
            string valor;
            //
            Console.WriteLine("Calculadora");

            do
            {
                Console.WriteLine("Operaciones disponibles: 1-suma, 2-resta, 3-salir");
                op = Convert.ToInt32(Console.ReadLine());
                if (op != 3)
                {
                    Console.WriteLine("Ingrese primer numero: ");
                    a = Convert.ToSingle(Console.ReadLine());

                    Console.WriteLine("Ingrese segundo numero: ");
                    b = Convert.ToSingle(Console.ReadLine());

                    switch (op)
                    {
                        case 1:
                            Console.WriteLine($"La suma de los numeros {a} + {b} es:{c = a + b} ");
                            break;
                        case 2:
                            Console.WriteLine($"La resta de los numeros {a} - {b} es:{c = a - b} ");
                            break;
                        default:
                            Console.WriteLine("Opción no contemplada, intentar de nuevo");
                            break;
                    }
                    Console.WriteLine("Resultado. {0}",c);
                }
                   


            } 
            while (op !=3 );
            Console.WriteLine("Fin del programa");
        }
    }
}
