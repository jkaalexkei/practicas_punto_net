using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int columnas = 0;
            Console.WriteLine("Numero de columnas");
            columnas = Convert.ToInt32(Console.ReadLine());//indicamos la cantidad de columnas que tendra el array

            int[][] jagged = new int[columnas][];//inicializamos el array

            for (int i = 0; i<columnas;i++)//recorremos las columnas
            {
                Console.WriteLine("Numero de filas para la columna {0}", i);
                jagged[i] = new int[Convert.ToInt32(Console.ReadLine())];//agregamos la cantidad de filas por columna
            }

            //recorremos el arreglo para agregar los valores que tendran cada fila por columna
            for (int c = 0; c < jagged.Length;c++)
            {
                Console.WriteLine("columna {0}",c);
                for (int f = 0; f < jagged[c].Length;f++)
                {
                    Console.Write($" fila {f} valor: ");
                    jagged[c][f] = Convert.ToInt32(Console.ReadLine());//agregamos los valores a las filas
                }
            }

            //recorremos las columnas para mostrar los valores registrados en cada fila y por cada columna
            Console.WriteLine("Valores Registrados");
            for (int col = 0; col < jagged.Length;col++)
            {
                Console.Write($"Valores columa {col}");
                for (int fil = 0; fil < jagged[col].Length;fil++)
                {
                    Console.Write($"{jagged[col][fil]}");
                    
                    
                }
                Console.WriteLine();
            }

        }
    }
}
