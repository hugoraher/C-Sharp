using System;

namespace ÁreaPrisma_Recto
{
    class Program
    {
        /**
        * Nombre del programa: Área de un Prisma Recto.
        * ---
        * "El programa Área de un Prisma Recto, calcula el área de un Prisma Recto mediante los datos que ingresa el usuario.
        * Para desarrollar éste programa: Se utilizó la clase Scanner, el operador "* y +".
        * ---
        * Fecha de creación: 20/04/2021
        * Hora: 10:32 am
        * @author Víctor Hugo Raher
        * Fecha última de modificación: / /
        * Hora última de modificación: : 
        */

        static void Main(string[] args)
        {
            int a, P, al, ar;       //Se declaran las variables.
            Console.WriteLine("\t\t\t\t\t\tÁrea de un Prisma\n");       //Línea impresa del título del programa.
            Console.Write("Ingresa el número para el Perímetro: ");     //Primer mensaje de impresión para ingresar datos por teclado.
            P = Convert.ToInt16(Console.ReadLine());                    //Lee los datos que ingresan por teclado.

            Console.Write("Ingresa el número para la altura: ");        //Segundo mensaje de impresión para ingresar datos por teclado.
            al = Convert.ToInt16(Console.ReadLine());                   //Lee los datos que ingresan por teclado.

            Console.Write("Ingresa el número para el área: ");          //Tercer mensaje de impresión para impresar datos por teclado.
            a = Convert.ToInt16(Console.ReadLine());                    //Lee los datos que ingresan por teclado.

            a = P * (al + a);                                           //Área= P * (al + a);

            Console.Write("El área del prisma recto es: " + a);         //Línea de impresión para mostrar el resultado.
        }
    }
}
