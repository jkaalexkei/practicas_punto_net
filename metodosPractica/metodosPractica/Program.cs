using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodosPractica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Metodos");
            mensaje();
            Console.WriteLine(mensajeNuevo());
            Console.WriteLine(sumaNumeros(2, 2));
            for (int i = 0; i < numeros().Length; i++) {
                Console.WriteLine(numeros()[i]);
            }
        }

        static void mensaje()
        {
            Console.WriteLine("Hola Mundo");
        }

        static string mensajeNuevo()
        {
            return "Hola Mundo";
        }

        static int sumaNumeros(int a, int b) => a + b;

        static int[] numeros()
        {
            int[] array = new int[4] { 1,2,3,4};
            return array;
        }

    }
}
