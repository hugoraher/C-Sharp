using System;

namespace HorarioDia
{
    class Program
    {
        static void Main(string[] args)
        {

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
