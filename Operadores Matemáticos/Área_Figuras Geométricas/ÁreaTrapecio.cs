using System;

namespace ÁreaTrapecio
{
    class Program
    {
        /**
        * Nombre del programa: Área de un Trapecio.
        * ---
        * "El programa Área de un Trapecio, calcula el área de un trapecio mediante los datos que ingresa el usuario.
        * Para desarrollar éste programa: Se utilizó la clase Scanner, el operador "*, + y /".
        * ---
        * Fecha de creación: 28/04/2021
        * Hora: 16:54 pm
        * @author Víctor Hugo Raher
        * Fecha última de modificación: / /
        * Hora última de modificación: : 
        */
        static void Main(string[] args)
        {
            int a, B, b, h;                                             //Se declaran variables.
            Console.Write("\t\t\t\t\t\tÁrea de un Trapecio\n");         //Línea impresa del título del programa.

            Console.Write("Ingresa el número para la Base mayor: ");    //Primer mensaje de impresión para ingresar datos por teclado.
            B = Convert.ToInt16(Console.ReadLine());                    //Lee los datos que ingresan por teclado.

            Console.Write("Ingresa el número para la base menor: ");    //Segundo mensaje de impresión para ingresar datos por teclado.
            b = Convert.ToInt16(Console.ReadLine());                    //Lee los datos que ingresan por teclado.

            Console.Write("Ingresa el número para la altura:     ");    //Tercer mensaje de impresión para ingresar datos por teclado.
            h = Convert.ToInt16(Console.ReadLine());                    //Lee los datos que ingresan por teclado.

            a = (B + b) * h / 2;                                        //Área = (Diagonal mayor + diagonal menor) * h / 2.

            Console.Write("El área del trapecio es: " + a);             //Línea de impresión para mostrar el resultado.
        }
    }
}
