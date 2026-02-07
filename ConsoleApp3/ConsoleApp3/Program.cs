using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool graduado;
            string valor;
            double nota1, nota2,promedio;

            graduado = true;
            Console.WriteLine("Ingresa si o no si haz estudiado: ");
            valor = Console.ReadLine();
            nota1 = 20;
            nota2 = 15;
            if (valor == "si" && graduado == true)
            {
                Console.WriteLine($"Eres profesional y con un promedio de {(nota1 + nota2) / 2} ");
                
            }
            else
            {
                Console.WriteLine("Te falta completar los estudios");
            }
        }
    }
}
