using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            

            Console.WriteLine("ingrese el numero de elementos del array: ");
            numero = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[numero];

            for (int i = 0; i < numero; i++)
            {
                array[i] = i;
                Console.WriteLine(array[i]);
            }
            Console.WriteLine($"fin del programa {array.}");
            Console.ReadKey();
        }
    }
}
