using System;
using System.Collections.Generic;


namespace TeslaSystem
{
    // Declaración de la estructura Tesla que almacena información sobre un automóvil Tesla
    public struct Tesla
    {
        public string Modelo; // El modelo del Tesla
        public int Anio; // El año del Tesla
        public double KmActual; // El kilometraje actual del Tesla
        public double KmService; // El kilometraje del último service del Tesla
        public string Color; // El color del Tesla
        public string Dueno; // El dueño del Tesla
    }

    public class Program
    {
        // Declaración de la lista de Teslas
       public static List<Tesla> TeslaList = new List<Tesla>();

        static void Main(string[] args)
        {
            while (true)
            {
                // Menú principal del programa
                Console.WriteLine("\n\nBienvenido al Sistema Tesla!");
                Console.WriteLine("Seleccione una opcion:");
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
                        Alta.DarDeAlta();
                        break;
                    case 2:
                        Eliminar.EliminarTesla();
                        break;
                    case 3:
                        OrdenadoPorAnio.ListadoOrdenadoPorAnio();
                        break;
                    case 4:
                        OrdenadoPorKms.ReordenarPorKms();
                        break;
                    case 5:
                        MostrarMasKm.MostrarMasKms();
                        break;
                    default:
                        Console.WriteLine("Opcion inválida.");
                        break;
                }
            }
        }
    }
}
