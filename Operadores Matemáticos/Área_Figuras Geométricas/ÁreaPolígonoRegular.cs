using System;

namespace ÁreaPolígonoRegular
{
    class Program
    {
        /**
        * Nombre del programa: Área de un Polígono Regular.
        * ---
        * "El programa Área de un Polígono Regular, calcula el área de un polígono regular mediante los datos que ingresa el usuario.
        * Para desarrollar éste programa: Se utilizó la clase Scanner, el operador "* y /".
        * ---
        * Fecha de creación: 19/04/2021
        * Hora: 12:06 pm
        * @author Víctor Hugo Raher
        * Fecha última de modificación: / /
        * Hora última de modificación: : 
        */

        static void Main(string[] args)
        {
            int a, Pe, Ap;      //Se declaran variables.
            Console.WriteLine("\t\t\t\t\t\tÁrea de un Polígono Regular\n");         //Línea impresa del título del programa.
            Console.Write("Ingresa el número del Perímetro: ");                     //Primer mensaje de impresión para ingresar datos por teclado.
            Pe = Convert.ToInt16(Console.ReadLine());                               //Lee los datos que ingresan por teclado.

            Console.Write("Ingresa el número del apotema: ");                       //Segundo mensaje de impresión para ingresar datos por teclado.
            Ap = Convert.ToInt16(Console.ReadLine());                               //Lee los datos que ingresan por teclado.

            a = Pe * Ap / 2;                                                        //Área= Perímetro * Apotema / 2.

            Console.WriteLine("El área del Polígono Regular es: " + a);             //Línea de impresión para mostrar el resultado.
        }
    }
}
