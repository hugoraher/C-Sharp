using System;

namespace HorarioEscolar
{
    class HorarioEscolar { 

    //Comentarios de documentación
    /**
    * Nombre del programa: Horario Escoalr
    * ---
    * "El programa es un Horario Escolar en el que el alumno, consulta su actividad escolar ingresando su número de matricula".
    * Para desarrollar éste programa: Se utilizó la clase Scanner y la declaración Switch.
    * ---
    * Fecha de creación: 07/03/2021
    * Hora: 10:57 am
    * @author Víctor Hugo Raher
    * Fecha última de modificación: 07/03/2021
    * Hora última de modificación:  11:47 am
    */                           
        
        static void Main(string[] args)
        {
        
        //Declaración de variables
        String dia1, dia2, dia3, dia4, dia5, hora1, hora2, hora3, hora4, materia1, materia2, materia3, materia4, salon1, salon2, salon3, salon4,
        nombre;

        //Inicio de asignación de valor a variables.
        dia1 = "Lunes";
        dia2 = "Martes";
        dia3 = "Miercoles";
        dia4 = "Jueves";
        dia5 = "Viernes";

        hora1 = "07:00 - 09:00 am";
        hora2 = "09:00 - 11:00 am";
        hora3 = "11:00 - 13:00 pm";
        hora4 = "13:00 - 14:00 pm";

        materia1 = "Fundamentos de Programación";
        materia2 = "Fundamentos de Base de Datos";
        materia3 = "Fundamentos de Redes";
        materia4 = "Fundamentos de Software";

        salon1 = "Edificio M-Salón 16";
        salon2 = "Edificio M-Salón 12";
        salon3 = "Edificio B-Salón 11";
        salon4 = "Edificio F-Salón 9";
        //Fin de asignación de valor a variables.


        nombre = "Víctor Hugo";                 //Modificar el nombre de usuario.
        Console.Write("Ingresa tu número de matricula: ");      //Mensaje de impresión que solicita datos al usuario por teclado (sólo números).
        int matricula=Convert.ToInt32(Console.ReadLine());      //Se declara la variable que trabajará con el método readLine.
                                                                //El método ReadLine sirve para ingresar datos desde el teclado.
        Console.Write("¿Qué día es hoy?: ");                    //Mensaje de impresión que solicita datos al usuario por teclado.
        string ndia = Convert.ToString(Console.ReadLine());     //Lee los datos que ingresa el usuario.


            switch (ndia)
            {                         //Inicio de la declaración Switch
                                      //Cambiar materias y horario a convenir.
                case "Lunes":
                    Console.WriteLine("\nHola " + nombre + "," + " tu horario para el día de hoy " + ndia + " es: ");
                    Console.WriteLine("\nDía\t\tHora\t\t\tMateria\t\t\t\t\tSalón");
                    Console.WriteLine("\n" + dia1 + "\t\t" + hora1 + "\t" + materia1 + "\t\t" + salon1 + "\n"
                                      + "\t\t" + hora2 + "\t" + materia2 + "\t\t" + salon2 + "\n"
                                      + "\t\t" + hora3 + "\t" + materia3 + "\t\t\t" + salon3 + "\n"
                                      + "\t\t" + hora4 + "\t" + materia4 + "\t\t\t" + salon4 + "\n\n");
                    Console.WriteLine("¡Que tengas un excelente día!\n");
                    break;
                case "Martes":
                    Console.WriteLine("\nHola " + nombre + "," + " tu horario para el día de hoy " + ndia + " es: ");
                    Console.WriteLine("\nDía\t\tHora\t\t\tMateria\t\t\t\t\tSalón");
                    Console.WriteLine("\n" + dia2 + "\t\t" + hora1 + "\t" + materia1 + "\t\t" + salon1 + "\n"
                                      + "\t\t" + hora2 + "\t" + materia2 + "\t\t" + salon2 + "\n"
                                      + "\t\t" + hora3 + "\t" + materia3 + "\t\t\t" + salon3 + "\n");
                    Console.WriteLine("¡Que tengas un excelente día!\n");
                    break;
                case "Miercoles":
                    Console.WriteLine("\nHola " + nombre + "," + " tu horario para el día de hoy " + ndia + " es: ");
                    Console.WriteLine("\nDía\t\tHora\t\t\tMateria\t\t\t\t\tSalón");
                    Console.WriteLine("\n" + dia3 + "\t" + hora2 + "\t" + materia2 + "\t\t" + salon2 + "\n"
                                      + "\t\t" + hora3 + "\t" + materia3 + "\t\t\t" + salon3 + "\n"
                                      + "\t\t" + hora4 + "\t" + materia4 + "\t\t\t" + salon4 + "\n\n");
                    Console.WriteLine("¡Que tengas un excelente día!\n");
                    break;
                case "Jueves":
                    Console.WriteLine("\nHola " + nombre + "," + " tu horario para el día de hoy " + ndia + " es: ");
                    Console.WriteLine("\nDía\t\tHora\t\t\tMateria\t\t\t\t\tSalón");
                    Console.WriteLine("\n" + dia4 + "\t\t" + hora3 + "\t" + materia3 + "\t\t\t" + salon3 + "\n"
                                      + "\t\t" + hora4 + "\t" + materia4 + "\t\t\t" + salon4 + "\n\n");
                    Console.WriteLine("¡Que tengas un excelente día!\n");
                    break;
                case "Viernes":
                    Console.WriteLine("\nHola " + nombre + "," + " tu horario para el día de hoy " + ndia + " es: ");
                    Console.WriteLine("\nDía\t\tHora\t\t\tMateria\t\t\t\t\tSalón");
                    Console.WriteLine("\n" + dia5 + "\t\t" + hora4 + "\t" + materia4 + "\t\t\t" + salon4 + "\n\n");
                    Console.WriteLine("¡Que tengas un excelente día!\n");
                    break;
                default:
                    Console.WriteLine("El día no existe.");
                    break;
            }                                       //Fin de la declaración Switch.
        }
    }
}
