using System;

namespace MayoríaEdad2
{
    class Program
    {
        //Comentarios de documentación
        /**
         * Nombre del programa: Mayoría de edad 2.
         * ---
         * "El programa solicita al usuario ingresar su edad, si éste cumple la mayoría de edad, se permite
         * el acceso. Si no, se le niega por ser menor de edad. Además, para constatar la mayoría de edad. Se solicita
         * ingrear el año de nacimiento.
         * Para desarrollar éste programa: Se utilizó la declaración if-else.
         * ---
         * Fecha de creación: 08/04/2021
         * Hora: 13:23 pm
         * @author Víctor Hugo Raher
         * Fecha última de modificación: //
         * Hora última de modificación:   : 
         */

        static void Main(string[] args)
        {
            int edad, año;          //Se declaran las variables edad y año.

            Console.Write("Ingresa tu edad: ");                 //Impresión de pantalla solicitando datos al usuario.
            edad = Convert.ToInt16(Console.ReadLine());         //Lee los datos que ingresa el usuario.

            Console.Write("Para constatar que eres mayor de edad, ingresa el año de tu nacimiento: ");     //Impresión de pantalla solicitando datos al usuario.
            año = Convert.ToInt16(Console.ReadLine());                                                     //Lee los datos que ingresa el usuario.

            if (año<=2003)          //Inicia la declaración if-else.
            {
                Console.WriteLine("Tu edad si cumple el requisito para ingresar.");     //Impresión de mensaje 1.
            }
            else
            {
                Console.WriteLine("Tu edad no cumple el requisito para ingresar.");
            }                       //Finaliza la declaración if-else.
        }
    }
}
