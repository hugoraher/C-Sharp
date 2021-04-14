using System;

namespace ÁreaCuadrado
{
    class Program
    {
        /**
        * Nombre del programa: Área de un Cuadrado.
        * ---
        * "El programa Área de un Cuadrado, calcula el área de un cuadrado mediante los datos que ingresa el usuario.
        * Para desarrollar éste programa: Se utilizó la clase Scanner y el operador "*".
        * ---
        * Fecha de creación: 14/04/2021
        * Hora: 13:51 pm
        * @author Víctor Hugo Raher
        * @version java 1.8.0_281
        * Fecha última de modificación: / /2021
        * Hora última de modificación: : 
        */
        static void Main(string[] args)
        {
            int a, la1, la2;        //Se declaran las variables
            Console.WriteLine("\t\t\t\t\t\tÁrea de un Cuadrado\n");     //Línea impresa del título del programa.
            Console.Write("Ingresa el número para el lado 1: ");        //Primer mensaje de impresión para ingresar datos por teclado.
            la1 = Convert.ToInt16(Console.ReadLine());                  //Lee los datos que ingresan por teclado.

            Console.Write("Ingresa el número para el lado 2: ");        //Segundo mensaje de impresión para ingresar datos por teclado.
            la2 = Convert.ToInt16(Console.ReadLine());                  //Lee los datos que ingresan por teclado.

            a = la1 * la2;                                              //Área=lado*lado;

            Console.Write("El área del cuadrado es: " + a);             //Línea de impresión para mostrar el resultado.
        }
    }
}
