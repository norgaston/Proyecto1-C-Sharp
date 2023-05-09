using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeslaSystem
{
    // Función para ordenar Teslas por kilómetros
    public class OrdenadoPorKms
    {
        public static void ReordenarPorKms()
        {
            // Ordena la lista de Teslas por kilómetros utilizando la función Sort y una lambda expression que compara los kilómetros de dos Teslas.
            Program.TeslaList.Sort((x, y) => x.KmActual.CompareTo(y.KmActual));
            Console.WriteLine("\n\nListado de Teslas reordenados por kilometraje actual:");
            // Recorre la lista ordenada y muestra la información de cada Tesla.
            foreach (Tesla t in Program.TeslaList)
            {
                Console.WriteLine($"Modelo: {t.Modelo}, Año: {t.Anio}, Kilometraje: {t.KmActual}, Dueño: {t.Dueno}");
            }
        }

    }
}
