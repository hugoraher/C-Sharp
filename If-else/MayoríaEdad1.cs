using System;

namespace MayoríaEdad1
{
    class Program
    {
        /**
         * Nombre del programa: Mayoría de edad.
         * ---
         * "El programa solicita al usuario ingresar su edad, si éste cumple la mayoría de edad, se permite
         * el acceso. Si no, se le niega por ser menor de edad.
         * Para desarrollar éste programa: Se utilizó la declaración if-else.
         * ---
         * Fecha de creación: 07/04/2021
         * Hora: 11:35 am
         * @author Víctor Hugo Raher
         * Fecha última de modificación: / /
         * Hora última de modificación:  : 
         */
        static void Main(string[] args)
        {
            int edad;       //Se declara la variable "edad".
            Console.Write("Ingresa tu edad: ");     //Impresión de pantalla solicitando datos al usuario.
            edad = Convert.ToInt16(Console.ReadLine());     //Lee los datos que ingresa el usuario.

            if (edad >= 18)                 //Inicia la declaración if-else.
            {                               
                Console.WriteLine("Tu edad si cumple el requisito para ingresar. ");        //Impresión de mensaje 1.
            }else
            {
                Console.WriteLine("Tu edad no cumple el requisito para ingresar. ");        //Impresión de mensaje 2.
            }                               //Finaliza la declaración if-else.
        }
    }
}
