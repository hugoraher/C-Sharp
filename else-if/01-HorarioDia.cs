using System;

namespace HorarioDia
{
    class Program
    {
    
    //Comentarios de documentación
    /**
    * Nombre del programa: Hora del día.
    * ---
    * "El programa rectifica la hora del día por medio de un saludo y los datos que ingrese el usuario por medio del teclado".
    * Para desarrollar éste programa: Se utilizó la clase Scanner y la declaración else if.
    * ---
    * Fecha de creación: 07/03/2021
    * Hora: 10:57 am
    * @author Víctor Hugo Raher
    * Fecha última de modificación: 07/03/2021
    * Hora última de modificación:  11:47 am
    */   
        
        
        static void Main(string[] args)
        {
            //int hora = 24;            //se declara la variable y se le asigna valor

            Console.Write("Ingresa la hora del día en formato de 24 horas, por favor: "); //Se solicita al usuario ingresar datos por el teclado 
            int hora = Convert.ToInt32(Console.ReadLine());

            if (hora < 6)
            {             //Inicia la declaración "else if"
                Console.Write("Son las " + hora + " am," + " es hora de dormir.");
            }
            else if (hora < 12)
            {
                Console.Write("Son las " + hora + " am," + " buenos días.");
            }
            else if (hora < 18)
            {
                Console.Write("Son las " + hora + " pm," + " buenas tardes.");
            }
            else if (hora < 24)
            {
                Console.Write("Son las " + hora + " pm," + " buenas noches.");
            }
            else
            {
                Console.Write("La hora no existe.");
            }                       //Termina la declaración "else if"
        }
    }
}
