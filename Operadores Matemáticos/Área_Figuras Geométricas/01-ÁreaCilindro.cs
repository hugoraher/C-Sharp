using System;

namespace ÁreaCilindro
{
    class Program
    {
        /**
        * Nombre del programa: Área de un Cilindro.
        * ---
        * "El programa Área de un Cilindro, calcula el área de un cilindro mediante los datos que ingresa el usuario.
        * Para desarrollar éste programa: Se utilizó el operador " * y + ".
        * ---
        * Fecha de creación: 09/04/2021
        * Hora: 06:45 am
        * @author Víctor Hugo Raher
        * Fecha última de modificación: / /
        * Hora última de modificación: : 
        */
        
        static void Main(string[] args)
        {
            double a, h, R;         //Se declaran las variables.

            Console.WriteLine("\t\t\t\t\t\tÁrea de un Cilindro\n");     //Línea impresa del título del programa.

            Console.Write("Ingresa el número para 'R=Radio': ");        //Primer mensaje de impresión para ingresar datos por teclado.
            R = Convert.ToInt16(Console.ReadLine());                    //Lee los datos que ingresa el usuario.

            Console.Write("Ingresa el número para la altura: ");        //Segudno mensaje de impresión para ingresar datos por teclado.
            h = Convert.ToInt16(Console.ReadLine());                    //Lee los datos que ingresa el usuario.

            a = 2 * Math.PI * R * (h + R);                              //Área = 2 * PI * R (h + R).

            Console.WriteLine("El área del cilíndro es: " + a);         //Línea de impresión para mostrar el resultado.
        }
    }
}
