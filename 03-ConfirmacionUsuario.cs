using System;

namespace ConfirmacionUsuario
{
    class ConfirmacionUsuario
    {
        //Comentarios del programa.
        /**
        * Nombre del programa: Confirmación de usuario y contraseña.  
        * ---
        * "El programa solicita que se ingrese Usuario y Contraseña. En caso de que éstos sean correctos,
        * permite el acceso, si no lo son, solicita nuevamente los datos mencionados".
        * Para desarrollar éste programa: Se utilizó la clase Scanner y la declaración if-else.
        * ---
        * Fecha de creación: 26/02/2021
        * Hora: 15:03 pm
        * @author Víctor Hugo Raher
        * Fecha última de modificación: 01/03/2021
        * Hora última de modificación:  09:20 am
        * 
        **/
        static void Main(string[] args)
        {
            String usuario, contrasena;                                  //Se declaran las variables.
            Console.Write("Ingresa tu usuario: ");                       //Se solicita al usuario ingresar su usuario.   
            usuario = Convert.ToString(Console.ReadLine());              //Lee los datos que ingresa el usuario.

            Console.Write("Ingresa tu contraseña: ");                    //Se solicita al usuario ingresar su contraseña.
            contrasena = Convert.ToString(Console.ReadLine());           //Lee los datos que ingresa el usuario.

            if ("Victor Hugo".Equals(usuario))                           //Inicia la declaración if-else.
            {                                                            //Modifica el nombre.

            }

            if ("Raher".Equals(contrasena))                              //Modifica la contraseña.
            {                                 
                Console.WriteLine("Usuario y contraseña correcta, 'bienvenido al sistema'.");
                //Impresión de mensaje con datos correctos.
            }
            else
            {
                Console.WriteLine("Usuario y contraseña incorrecta, vuelve a intentarlo.");
                //Impresión de mensaje con datos incorrectos.
            }
        }
    }
}
