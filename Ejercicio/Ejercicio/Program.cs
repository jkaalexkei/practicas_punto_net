using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Operaciones matemáticas

                Desarrollar un programa que permita hacer las siguientes operaciones matemáticas: Suma, resta, multiplicación y división. Además de estas opciones también debe darle al usuario la opción de salir.

                El programa debe permitir hacer las operaciones que sean necesarias, es decir las que el usuario quiera o solamente una.
             
             */

            float n1, n2, r;
            int opcion;
            string val;
            Console.WriteLine("Programa de operaciones matematicas");
            inicio:
            Console.WriteLine("Elige una opción: 1.Suma, 2.Resta, 3.Multiplicación, 4.División, 5.Salir");
            opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion < 1 || opcion > 5)
            {
                Console.WriteLine("La opcion seleccionada no esta contemplada");
                goto inicio;
            }
            else
            {
                Console.WriteLine("Bienvenido al programa");
                while (opcion != 5)
                {
                rectificacion:
                    Console.Write("Ingrese primer numero: ");
                    n1 = Convert.ToSingle(Console.ReadLine());
                    Console.Write("Ingrese segundo numero: ");
                    n2 = Convert.ToSingle(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("La operación seleccionada es suma");
                            r = n1 + n2;
                            Console.WriteLine($"el resultado es : {r}");
                            Console.WriteLine("Desea realizar otra operación, si o no");
                            val = Console.ReadLine();
                            if (val =="si")
                            {
                                goto inicio;
                            }
                            else
                            {
                                Console.WriteLine("Fin del programa");
                                return;
                            }
                            
                        case 2:
                            Console.WriteLine("La operación seleccionada es resta");
                            r = n1 - n2;
                            Console.WriteLine($"el resultado es : {r}");
                            Console.WriteLine("Desea realizar otra operación, si o no");
                            val = Console.ReadLine();
                            if (val == "si")
                            {
                                goto inicio;
                            }
                            else
                            {
                                Console.WriteLine("Fin del programa");
                                return;
                            }
                           
                        case 3:
                            Console.WriteLine("La operación seleccionada es multiplicación");
                            r = n1 * n2;
                            Console.WriteLine($"el resultado es : {r}");
                            Console.WriteLine("Desea realizar otra operación, si o no");
                            val = Console.ReadLine();
                            if (val == "si")
                            {
                                goto inicio;
                            }
                            else
                            {
                                Console.WriteLine("Fin del programa");
                                return;
                            }
                            
                        case 4:
                            Console.WriteLine("La operación seleccionada es división");
                            if (n1 == 0f || n2 == 0f)
                            {
                                Console.WriteLine($"Alguno de los números {n1} o {n2} es invalido !rectifica¡");
                                goto rectificacion;
                                
                            }
                            else
                            {
                                r = n1 / n2;

                            }
                                
                            Console.WriteLine($"el resultado es : {r}");
                            Console.WriteLine("Desea realizar otra operación, si o no");
                            val = Console.ReadLine();
                            if (val == "si")
                            {
                                goto inicio;
                            }
                            else
                            {
                                Console.WriteLine("Fin del programa");
                                return;

                            }
                            
                        case 5:
                            Console.WriteLine("Haz finalizado el programa");
                            return;
                        default:
                            Console.WriteLine("La opción no esta contemplada");
                            goto inicio;


                    }
                }
                Console.WriteLine("Haz finalizado el programa");
                Console.ReadKey();


            }

        }
    }
    
}
