using System;

namespace ÁreaTriángulo
{
    class Program
    {
        /**
         * Nombre del programa: Área de un Triángulo.
         * ---
         * "El programa Área de un Triángulo, calcula el área de un triángulo mediante los datos que ingresa el usuario.
         * Para desarrollar éste programa: Se utilizó la clase Scanner, el operador "* y /".
         * ---
         * Fecha de creación: 03/05/2021
         * Hora: 13:27 pm
         * @author Víctor Hugo Raher
         * Fecha última de modificación: / /
         * Hora última de modificación: : 
         *
         */
        static void Main(string[] args)
        {
            int a, ba, al;                                                  //Se declaran las variables.
            Console.Write("\t\t\t\t\t\tÁrea de un Triángulo:\n\n");         //Línea impresa del título del programa.
            Console.Write("Ingresa la base: ");                             //Primer mensaje de impresión para ingresar datos por teclado.
            ba = Convert.ToInt16(Console.ReadLine());                       //Lee los datos que ingresan por teclado.

            Console.Write("Ingresa la altura: ");                           //Segundo mensaje de impresión para ingresar datos por teclado.
            al = Convert.ToInt16(Console.ReadLine());                       //Lee los datos que ingresan por teclado.

            a = ba * al / 2;                                                 //Área = base * altura / 2.

            Console.Write("El área del triángulo es: " + a);                //Línea de impresión para mostrar el resultado.
        }
    }
}
