using System;
using System.Collections.Generic;

namespace TeslaSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaración de la lista de Teslas
            List<Tesla> TeslaList = new List<Tesla>();

            // Menú principal del programa
            Console.WriteLine("\n\nBienvenido al Sistema Tesla!");
            Console.WriteLine("                    ___..................____");
            Console.WriteLine("           _..--''~_______   _____...----~~~\\");
            Console.WriteLine("       __.'    .-'~       \\~      [_`.7     \\");
            Console.WriteLine(" .---~~      .'            \\           __..--\\_");
            Console.WriteLine("/             `-._          \\   _...~~~_..---~  ~~~~~~~~~~~~--.._");
            Console.WriteLine("\\              /  ~~~~~~----_\\`-~_-~~__          ~~~~~~~---.._    ~--.__");
            Console.WriteLine(" \\     _       |==            |   ~--___--------...__          `-   _.--\"\"\"|");
            Console.WriteLine("  \\ __/.-._\\   |              |            ~~~~--.  `-._ ___...--~~~_.'|_Y |");
            Console.WriteLine("   `--'|/~_\\  |              |     _____           _.~~~__..--~~_.-~~~.-~/");
            Console.WriteLine("     | ||| |\\_|__            |.../.----.._.        | Y |__...--~~_.-~  _/");
            Console.WriteLine("      ~\\\\\\ || ~|..__---____   |||||  .'~-. \\\\       |_..-----~~~~   _.~~");
            Console.WriteLine("        \\`-'/ /     ~~~----...|'''|  |/\"_\"\\ \\\\   |~~'           __.~");
            Console.WriteLine("         `~~~'                 ~~-:  ||| ~| |\\  |        __..~~");
            Console.WriteLine("                                   ~~|||  | | \\/  _.---~~");
            Console.WriteLine("                                     \\\\\\  //  | ~~~");
            Console.WriteLine("                                      \\`-'/  / ");
            Console.WriteLine("                                       `~~~~'");



            while (true)
            {

                Console.WriteLine("\nSeleccione una opción:");
                Console.WriteLine("1 - Dar de alta un Tesla.");
                Console.WriteLine("2 - Eliminar un Tesla.");
                Console.WriteLine("3 - Mostrar un listado de los Tesla ordenados por año.");
                Console.WriteLine("4 - Reordenar el listado de los Tesla por kms.");
                Console.WriteLine("5 - Mostrar el Tesla con más kms.");
                Console.WriteLine("0 - Salir.");

                // Obtener la opción seleccionada por el usuario
                int opcion = Convert.ToInt32(Console.ReadLine());

                // Realizar la acción correspondiente a la opción seleccionada
                switch (opcion)
                {
                    case 0:
                        Console.WriteLine("Gracias por utilizar el Sistema Tesla!");
                        return;
                    case 1:
                        TeslaFunctions.DarDeAlta(TeslaList);
                        break;
                    case 2:  
                        TeslaFunctions.EliminarTesla(TeslaList);
                        break;
                    case 3:
                        TeslaFunctions.ListadoOrdenadoPorAnio(TeslaList);
                        break;
                    case 4:
                        TeslaFunctions.ReordenarPorKms(TeslaList);
                        break;
                    case 5:
                        TeslaFunctions.MostrarMasKms(TeslaList);
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            }
        }
    }
}
