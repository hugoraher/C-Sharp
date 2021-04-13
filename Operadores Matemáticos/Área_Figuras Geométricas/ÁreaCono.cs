using System;

namespace ÁreaCono
{
    class Program
    {
        /**
        * Nombre del programa: Área de un Cono.
        * ---
        * "El programa Área de un Cono, calcula el área de un cono mediante los datos que ingresa el usuario.
        * Para desarrollar éste programa: Se utilizó el operador " * y + ".
        * ---
        * Fecha de creación: 12/04/2021
        * Hora: 16:17 pm
        * @author Víctor Hugo Raher
        * Fecha última de modificación: 13/04/2021
        * Hora última de modificación: 08:30 am 
        */
        static void Main(string[] args)
        {
            double a, r, al, g;         //Se declaran las variables.

            Console.Write("\t\t\t\t\t\tÁrea de un Cono\n\n");     //Línea impresa del título del programa.

            Console.Write("Ingresa el número para el radio: "); //Primer mensaje de impresión para ingresar datos por teclado.
            r = Convert.ToInt16(Console.ReadLine());            //Lee los datos que ingresa el usuario.

            Console.Write("Ingresa el número para la altura: "); //Segundo mensaje de impresión para ingresar datos por teclado.
            al = Convert.ToInt16(Console.ReadLine());            //Lee los datos que ingresan por teclado.

            Console.Write("Ingresa el número para la generatriz: ");    //Tercer mensaje de impresión para ingresar datos por teclado.
            g = Convert.ToInt16(Console.ReadLine());                    //Lee los datos que ingresan por teclado.

            a = Math.PI * r * (al + g);                                 //Área=Pi * r * (al + g).

            Console.WriteLine("El área del Cono es: " + a);             //Línea de impresión para mostrar el resultado.
        }
    }
}
