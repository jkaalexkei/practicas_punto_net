using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios_varios
{
    internal class Program
    {

       

        static void Main(string[] args)
        {
            //programa para invertir 1 numero de 2 digitos
            int numero, division, residuo, numAuxiliar;
            string linea;
            Console.WriteLine("Ingresa un numero de 2 cifras");
         
            numero = Convert.ToInt32(Console.ReadLine());
            division = numero / 10;
            residuo = numero % 10;
            numAuxiliar = (residuo * 10) + division;

            Console.WriteLine("res division: " + division);
            Console.WriteLine("res residuo: " + residuo);
            Console.WriteLine("invertido: " + numAuxiliar);


            //codigo para invertir cualquier numero
            Console.WriteLine("Ingresa un numero entero: ");

            int numero2 = Convert.ToInt32(Console.ReadLine());
            int invertido = 0;//iniciamos en 0 para ir acumulado el nuevo valor de invertido en cada iteracion
            Console.WriteLine("valor inicial: " + invertido);
            while (numero2 > 0)
            {
                
                residuo = numero2 % 10;//aqui retornamos el ultimo digito del numero ingresado
                
                invertido = invertido * 10 + residuo;//aqui vamos acumulando el nuevo valor de invertido
               
                numero2 = numero2 / 10; //aca cortamos el ultimo digito del numero ingresado por tratarse de una division entera solo tomamos la parte entera del resultado
               
            }

            Console.WriteLine("resultado final: " + invertido);


        }
    }
}
