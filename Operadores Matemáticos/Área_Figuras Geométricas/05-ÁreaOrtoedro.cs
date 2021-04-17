using System;

namespace ÁreaOrtoedro
{
    class Program
    {
        /**
        * Nombre del programa: Área de un Ortoedro.
        * ---
        * "El programa Área de un Ortoedro, calcula el área de un ortoedro mediante los datos que ingresa el usuario.
        * Para desarrollar éste programa: Se utilizó la clase Scanner, el operador "* y +".
        * ---
        * Fecha de creación: 17/04/2021
        * Hora: 15:58 pm
        * @author Víctor Hugo Raher
        * Fecha última de modificación: / /
        * Hora última de modificación: : 
        */
        static void Main(string[] args)
        {
            int a, an, al, lon;     //Se declara la clase Scanner.
            Console.WriteLine("\t\t\t\t\t\tÁrea de un Ortoedro\n");     //Línea impresa del título del programa.

            Console.Write("Ingrea el número de ancho: ");               //Primer mensaje de impresión para ingresar datos por teclado.
            an = Convert.ToInt16(Console.ReadLine());                     //Lee los datos que ingresarn por teclado.

            Console.Write("Ingrea el número para la altura: ");         //Segundo mensaje de impresión para ingresar datos por teclado.
            al = Convert.ToInt16(Console.ReadLine());                     //Lee los datos que ingresarn por teclado.

            Console.Write("Ingrea el número para la longitud: ");       //Tercer mensaje de impresión para ingresar datos por teclado.
            lon = Convert.ToInt16(Console.ReadLine());                    //Lee los datos que ingresarn por teclado.

            a = 2 * (an * lon + an * al + lon * al);                    //Área= 2 * (a*b + a*c + b*c).

            Console.WriteLine("El área del ortoedro es: " + a);         //Línea de impresión para mostrar el resultado.

        }
    }
}
