using System;

namespace ÁreaRectángulo
{
    class Program
    {
        /**
        * Nombre del programa: Área de un Rectángulo.
        * ---
        * "El programa Área de un Rectángulo, calcula el área de un rectángulo mediante los datos que ingresa el usuario.
        * Para desarrollar éste programa: Se utilizó la clase Scanner y el operador "*".
        *---
        * Fecha de creación: 21/04/2021
        * Hora: 09:17 am
        * @author Víctor Hugo Raher
        * Fecha última de modificación: / /
        * Hora última de modificación: : 
        */
        static void Main(string[] args)
        {
            int a, ba, al;      //Se declaran variables.
            Console.Write("\t\t\t\t\t\tÁrea de un Rectángulo\n");       //Línea impresa del título del programa.
            Console.Write("Ingresa el número para la base: ");          //Primer mensaje de impresión para ingresar datos por teclado.
            ba = Convert.ToInt16(Console.ReadLine());                   //Lee los datos que ingresan por teclado.

            Console.Write("Ingresa el número para la altura: ");        //Segundo mensaje de impresión para ingresar datos por teclado.
            al = Convert.ToInt16(Console.ReadLine());                   //Lee los datos que ingresan por teclado.

            a = ba * al;                                                //Área = base * altura.

            Console.WriteLine("El área del rectángulo es: " + a);       //Línea de impresión para mostrar el resultado.
        }
    }
}
