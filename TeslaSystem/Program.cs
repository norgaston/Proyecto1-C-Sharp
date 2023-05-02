using System;
using System.Collections.Generic;

namespace TeslaSystem
{
    public struct Tesla
    {
        public string Modelo;
        public int Anio;
        public double KmActual;
        public double KmService;
        public string Color;
        public string Dueno;
    }

    class Program
    {
        static List<Tesla> TeslaList = new List<Tesla>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n\nBienvenido al Sistema Tesla!");
                Console.WriteLine("Seleccione una opcion:");
                Console.WriteLine("1 - Dar de alta un Tesla.");
                Console.WriteLine("2 - Eliminar un Tesla.");
                Console.WriteLine("3 - Mostrar un listado de los Tesla ordenados por año.");
                Console.WriteLine("4 - Reordenar el listado de los Tesla por kms.");
                Console.WriteLine("5 - Mostrar el Tesla con más kms.");
                Console.WriteLine("0 - Salir.");

                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 0:
                        Console.WriteLine("Gracias por utilizar el Sistema Tesla!");
                        return;
                    case 1:
                        DarDeAlta();
                        break;
                    case 2:
                        EliminarTesla();
                        break;
                    case 3:
                        ListadoOrdenadoPorAnio();
                        break;
                    case 4:
                        ReordenarPorKms();
                        break;
                    case 5:
                        MostrarMasKms();
                        break;
                    default:
                        Console.WriteLine("Opcion inválida.");
                        break;
                }
            }
        }

        static void DarDeAlta()
        {
            Tesla nuevoTesla = new Tesla();

            Console.WriteLine("\n\nIngrese el modelo:");
            nuevoTesla.Modelo = Console.ReadLine();

            Console.WriteLine("Ingrese el año:");
            nuevoTesla.Anio = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el kilometraje actual:");
            nuevoTesla.KmActual = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el kilometraje de service:");
            nuevoTesla.KmService = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el color:");
            nuevoTesla.Color = Console.ReadLine();

            Console.WriteLine("Ingrese el dueño:");
            nuevoTesla.Dueno = Console.ReadLine();

            TeslaList.Add(nuevoTesla);
            Console.WriteLine("Tesla agregado exitosamente!");
        }

        static void EliminarTesla()
        {
            Console.WriteLine("\n\nIngrese el indice del Tesla a eliminar:");
            int indice = Convert.ToInt32(Console.ReadLine());

            if (indice < TeslaList.Count)
            {
                TeslaList.RemoveAt(indice);
                Console.WriteLine("Tesla eliminado exitosamente!");
            }
            else
            {
                Console.WriteLine("Indice invalido.");
            }
        }

        static void ListadoOrdenadoPorAnio()
        {
            TeslaList.Sort((x, y) => x.Anio.CompareTo(y.Anio));
            Console.WriteLine("\n\nListado de Teslas ordenados por año:");
            foreach (Tesla t in TeslaList)
            {
                Console.WriteLine($"Modelo: {t.Modelo}, Año: {t.Anio}, Kilometraje: {t.KmActual}, Dueño: {t.Dueno}");
            }
        }
        static void ReordenarPorKms()
        {
            TeslaList.Sort((x, y) => x.KmActual.CompareTo(y.KmActual));
            Console.WriteLine("\n\nListado de Teslas reordenados por kilometraje actual:");
            foreach (Tesla t in TeslaList)
            {
                Console.WriteLine($"Modelo: {t.Modelo}, Año: {t.Anio}, Kilometraje: {t.KmActual}, Dueño: {t.Dueno}");
            }
        }

    static void MostrarMasKms()
        {
            Tesla maxKmTesla = TeslaList[0];

            foreach (Tesla t in TeslaList)
            {
                if (t.KmActual > maxKmTesla.KmActual)
                {
                    maxKmTesla = t;
                }
            }

            Console.WriteLine($"\n\nEl Tesla con más kilometraje es: {maxKmTesla.Modelo} ({maxKmTesla.Anio}), con {maxKmTesla.KmActual} km.");
        }
    }
}
