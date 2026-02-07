using System;//namespace predefinidos
using System.CodeDom.Compiler;
using System.Collections.Generic; //estructuras de datos genéricas (listas, diccionarios, colas).
using System.Linq; //consultas LINQ para colecciones. permite consultar datos
using System.Text; //manipulación de cadenas, codificación.
using System.Threading.Tasks; //programación asíncrona y paralela.

namespace ConsoleApp2 //namespace propio es un contenedor lógico que agrupa clases, interfaces y otros tipos.
{
    internal class Program //Significa que esta clase solo es accesible dentro del mismo assembly (el proyecto compilado).
    {
        static void Main(string[] args) //Es el punto de entrada de cualquier aplicación en C#.
           /*
            
            static: el método pertenece a la clase, no a un objeto.Se puede ejecutar sin instanciar Program.

            void: no devuelve ningún valor.

            string[] args: parámetro que recibe argumentos de la línea de comandos (ejemplo: programa.exe arg1 arg2).
           
            
            */
        {
            //ESTRUCTURAS SELECTIVAS
            //EXPRESION if
            //   if (expresion) si se cumple la expresion se ejecuta el codigo dentro del bloque a continuación
            //   {
            //       codigo a ejecutar
            //   }
            int a = 20;
            int b = 30;

            Console.WriteLine("Estructura selectiva IF, Validar dos numeros");
            if (a < b) { // aqui se pueden usar los operadores relacionales para realizar pruebas
                Console.WriteLine("Se cumple la condicion");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No se cumple la condición");
                Console.ReadKey();
            }

                //OPERADORES RELACIONALES
                //== igual
                //!= diferente
                //> mayor que
                //<menor que
                //>= mayor e igual
                //<= menor e igual
                //int a=5, b=2;
                //Console.WriteLine(a > b);
                //OPERADORES ARITMETICOS
                //byte num1 = 20;
                //byte num2 = 10;

                //int suma = num1 + num2;
                //int resta = num1 - num2;
                //int multiplicacion = num1 * num2;
                //int division = num1 / num2;
                //Console.WriteLine("*********************************************************************");
                //Console.WriteLine("Procesamiento de datos con datos ingresados por usuarios");
                //string nombre; int edad;
                //Console.WriteLine("Ingrese su nombre: ");
                //nombre= Console.ReadLine();
                //Console.WriteLine("Ingrese su edad: ");
                //edad = Convert.ToInt32(Console.ReadLine());

                //Console.WriteLine($"su nombre es {nombre} y su edad es: {edad}");
                //Console.WriteLine("*****************************************************************");


                //Console.WriteLine("El resultado de la suma es {0} ",suma);
                //Console.WriteLine("El resultado de la resta es {0} ",resta);
                //Console.WriteLine("El resultado de la multiplicacion es {0} ",multiplicacion);
                //Console.WriteLine("El resultado de la division es {0} ",division);


                //Console.ReadKey();

                //VARIABLES:
                //string nombre;//cadena
                //int edad =42;//entero

                //nombre = "alex";//
                //float estatura = 1.90f;//float
                //bool estudio = false;//booleano
                //decimal peso = 0m; //decimal
                //double valor = 0d;//double

                //Console.WriteLine("Mi nombre es: " + nombre + " y mi edad es: " + edad);//usando concatenación
                //Console.WriteLine("Mi nombre es: {0} y mi edad es: {1}",nombre,edad);//usando string format
                //Console.WriteLine($"Mi nombre es: {nombre} y mi edad es: {edad}",nombre,edad);//interpolación de cadena
                Console.ReadKey();

        }
    }
}
