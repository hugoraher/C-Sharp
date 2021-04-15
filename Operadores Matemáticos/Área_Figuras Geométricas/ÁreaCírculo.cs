using System;

namespace ÁreaCírculo
{
    class Program
    {
        /**
        * Nombre del programa: Área de un Círculo.
        * ---
        * "El programa Área de un Círculo, calcula el área de un círculo mediante los datos que ingresa el usuario.
        * Para desarrollar éste programa: Se utilizó la clase Scanner, el operador "*", la función Math.pow 'elevado al cuadrado' y la función Math.Pi.
        * ---
        * Fecha de creación: 28/03/2021
        * Hora: 06:45 am
        * @author Víctor Hugo Raher
        * Fecha última de modificación: / /
        * Hora última de modificación: : 
        */

        static void Main(string[] args)
        {
            double a, R;        //Se declaran las variables.
            Console.WriteLine("\t\t\t\t\t\tÁrea de un Círculo\n");      //Línea impresa del título del programa.

            Console.Write("Ingresa el número para 'R=Radio': ");        //Primer mensaje de impresión para ingresar datos por teclado.
            R = Convert.ToInt16(Console.ReadLine());                    //Lee los datos que ingresan por teclado.

            a = Math.PI * Math.Pow(R, 2);                               //Área= PI * R^2.

            Console.WriteLine("El área del círculo es: " + a);          //Línea de impresión para mostrar el resultado.
        }
    }
}

