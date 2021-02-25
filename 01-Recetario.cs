
using System;

namespace Recetario
{
    class Recetario

    //Comentarios de documentación
    /**
    * Nombre del programa: RecetasDeSopa  
    * ---
    * "El programa es un recetario de cocina que pide datos por medio del teclado al usuario y a su vez, muestra
    * el resultado que se solicita".
    * Para desarrollar éste programa: Se utilizó el método ReadLine y la declaración Switch.
    * ---
    * Fecha de creación: 17/02/2021
    * Hora: 08:00 am
    * @author Víctor Hugo Raher
    * Fecha última de modificación: 19/02/20
    * Hora última de modificación:  08:25 am
*/
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa el número de receta: "); //Impresión de pantalla que solicita ingresar datos al usuario.


            int nreceta = Convert.ToInt32(Console.ReadLine()); //Se declara la variable que trabajará con la clase readLine.
                                                               //La clase ReadLine sirve para ingresar datos desde el teclado.
                                                                   
            switch (nreceta)                                  //Se inicia la declaración Switch.
            {
                case 1:
                    Console.WriteLine("-La receta que elegiste es: Sopa Azteca.");      //Mensaje de la receta elejida.
                    Console.WriteLine("\nReceta para 4 porciones:\n-12 Tortillas cortadas (en cuadros, tiras o a su gusto)."
                        + "\n-1/4 de ajo picado."
                        + "\n-1/2 de cebolla picada."
                        + "\n-3 jitomates medianos."
                        + "\n-1 litro de agua."
                        + "\n-Epazote."
                        + "\n-Sal");

                    Console.WriteLine("\n\nModo de preparación:"            //Mensaje de para el usuario.
                        + "\n-Poner a calentar a fuego medio un sartén con aceite al gusto, freir las tortillas y sacarlas del mismo cuando estén crujientes."
                        + "\n-Agregar a la licuadora el 1/4 de ajo picado, la 1/2 cebolla picada, los 3 jitomates, el litro de agua"
                        + " y licuar hasta que todo esté mezclado."
                        + "\n-Poner una cacerola a fuego medio con un poco de aceite."
                        + "\n-Cortar cebolla y poner a sazonar en la cacerola."
                        + "\n-Vertir la mezcla de la licuadora en la cacerola y dejar hervir."
                        + "\n-Cuando esté hirviendo, poner el Epazote y dejar hervir por unos minutos a fuego bajo."
                        + "\n\nModo de servir:"
                        + "\n-En un plato ponga tortillas fritas, vierta la mezcla del jitomate y deguste a su elección.");


                    Console.WriteLine("\n\n¡Buen provecho!");        //Mensaje opcional.
                    break;         //Sentencia que rompe la iteración.

                case 2:
                    Console.WriteLine("-Usted elijió la receta de Sopa Mexica.");
                    Console.WriteLine("\nReceta para 4 porciones:\n-1 cebolla blanca picada finamente."
                        + "\n-2 cucharadas de aceite."
                        + "\n-4 elotes cortados."
                        + "\n-3 chiles poblanos asados, pelados y cortados en tiras."
                        + "\n-2 calabazas picadas en cubos."
                        + "\n-1 manojo de flores de calabaza sin tallos."
                        + "\n-4 tazas de agua."
                        + "\n-Sal.");

                    Console.WriteLine("\n\nModo de preparación:"            //Mensaje de para el usuario.
                          + "\n-En una cacerola vierte el aceite y dejar calentar por un instante."
                        + "Vierte la cebolla y dejar sazonar hasta que se torne un poco transparente."
                        + "\n-Vaciar el agua, los elotes, chiles y calabazas a cocer a fuego bajo por 20 minutos."
                        + "\n-Sazonar al gusto."
                        + "\n-Por último, agrega las flores de la calabaza y calienta por tres minutos más."
                        + "\n\n-Modo de servir:"
                        + "\n-En un plato servir la cantidad al gusto, y acompañar con lo que más le guste.");

                    Console.WriteLine("\n\n¡Buen provecho!");        //Mensaje opcional.
                    break;

                case 3:
                    Console.WriteLine("-Usted elijió la receta de Sopa de Amaranto.");
                    Console.WriteLine("\nReceta para 4 porciones:\n-1/2 cebolla picada en forma de media luna."
                        + "\n-2 litros de agua purificada."
                        + "\n-1 tasa de amaranto."
                        + "\n-Epazote."
                        + "\n-Sal.");

                    Console.WriteLine("\n\nModo de preparación:"            //Mensaje de para el usuario.
                         + "\n-Poner una cacerola con aceite a fuego medio y dejar calentar por un instante."
                        + "\n-Vaciar la cebolla picada y dejar sazonar hasta que se torne un poco transparente."
                        + "\n-Vaciar el agua, y dejar en el fuego medio hasta que hierva."
                        + "\n-Una vez el agua hervida, poner Epazote al gusto y dejar hervir 5 minutos más a fuego bajo."
                        + "\n-Vaciar la taza de Amaranto y mover hasta incorporar todos los ingredientes, dejar hervir por 10 minutos."
                        + "\n-Poner sal al gusto."
                        + "\n\n-Modo de servir:"
                        + "\nEn un plato, servir la cantidad de sopa al gusto. Acompañar con limón y chile en polvo.");

                    Console.WriteLine("\n\n¡Buen provecho!");        //Mensaje opcional.
                    break;

                //Espacio para más recetas.

                default:            //Mensaje en caso de que la receta que se busca, no existe.
                    Console.WriteLine("La receta que elegiste no existe.");
                    break;
            } //fin de la declaración Switch.
        }
    }
}
