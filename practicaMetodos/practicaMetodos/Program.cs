using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaMetodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] letras = new string[] { "1-agua","2-gaseosa","3-cocosette","4-pepito" };

            //int[] indices = new int[letras.Length];

            for (int i = 0; i < letras.Length; i++)
            {
                //indices[i] = Array.IndexOf(letras, letras[i]);//usando la clase Array y su metodo indexOf obtenemos los indices del array de letras
                Console.WriteLine(letras[i]);
            }

            //for (int j = 0; j < indices.Length; j++)
            //{
            //    Console.WriteLine(indices[j]);
            //}

            Console.WriteLine("Ingrese el numero de la letra que quieres obtener ");
            int dato = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(BuscarProducto(dato, letras));
            
            Console.WriteLine("Fin del programa");



        }

        static string BuscarProducto(int valor, string[] letras)
        {
            int buscarDato = valor - 1;//aqui convertimos a indice el dato ingresado por el usuario

            if (buscarDato >= 0 && buscarDato < letras.Length)
            {
                return letras[buscarDato];
            }
            else
            {
                return "Articulo no encontrado";
            }


        }
    }
}
