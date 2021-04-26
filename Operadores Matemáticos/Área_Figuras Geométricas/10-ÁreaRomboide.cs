using System;

namespace ÁreaRomboide
{
    class Program
    {
        /**
        * Nombre del programa: Área de un Romboide.
        * ---
        * "El programa Área de un Romboide, calcula el área de un romboide mediante los datos que ingresa el usuario.
        * Para desarrollar éste programa: Se utilizó la clase Scanner, el operador "*".
        * ---
        * Fecha de creación: 26/04/2021
        * Hora: 10:35 am
        * @author Víctor Hugo Raher
        * Fecha última de modificación: / /
        * Hora última de modificación: : 
        */
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t\t\tÁrea de un Romboide\n");     //Línea impresa del título del programa

            int a, ba, al;                                              //Se declaran variables.

            Console.Write("Ingresa el número para la base: ");          //Primer mensaje de impresión para ingresar datos por teclado.
            ba = Convert.ToInt16(Console.ReadLine());                   //Lee los datos que ingresan por teclado.

            Console.Write("Ingresa el número para la altura: ");        //Segundo mensaje de impresión para ingresar datos por teclado.
            al = Convert.ToInt16(Console.ReadLine());                   //Lee los datos que ingresan por teclado.

            a = ba * al;                                                //Área = base * altura.

            Console.Write("El área del romboide es: " + a);             //Línea de impresión para mostrar el resultado.
        }
    }
}
