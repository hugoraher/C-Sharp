using System;

namespace ÁreaRombo
{
    class Program
    {
        /**
        * Nombre del programa: Área de un Rombo.
        * ---
        * "El programa Área de un Rombo, calcula el área de un rombo mediante los datos que ingresa el usuario.
        * Para desarrollar éste programa: Se utilizó la clase Scanner, el operador "* y /".
        * ---
        * Fecha de creación: 22/04/2021
        * Hora: 11:00 am
        * @author Víctor Hugo Raher
        * Fecha última de modificación: / /
        * Hora última de modificación: : 
        */
        static void Main(string[] args)
        {
            int a, D, d;        //Se declaran las variables.
            Console.WriteLine("\t\t\t\t\t\tÁrea de un Rombo\n");                //Línea impresa del título del programa.
            Console.Write("Ingresa el número para la Diagonal mayor: ");        //Primer mensaje de impresión para ingresar datos por teclado.
            D = Convert.ToInt16(Console.ReadLine());                            //Lee los datos que ingresan por teclado.

            Console.Write("Ingresa el número para la diagonal menor: ");    //Segundo mensaje de impresión para ingresar datos por teclado.
            d = Convert.ToInt16(Console.ReadLine());                            //Lee los datos que ingresan por teclado.

            a = D * d / 2;                                                      //Área = Diagonal mayor * diagonal menor / 2.

            Console.WriteLine("El área del rombo es: " + a);                    //Línea de impresión para mostrar el resultado.
        }
    }
}
