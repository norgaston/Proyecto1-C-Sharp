using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeslaSystem
{
    public class OrdenadoPorAnio
    {

        // Función para ordenar Teslas por año
        public static void ListadoOrdenadoPorAnio()
        {
            // Ordena la lista de Teslas por año utilizando la función Sort y una lambda expression que compara los años de dos Teslas.
            Program.TeslaList.Sort((x, y) => x.Anio.CompareTo(y.Anio));
            Console.WriteLine("\n\nListado de Teslas ordenados por año:");
            // Recorre la lista ordenada y muestra la información de cada Tesla.
            foreach (Tesla t in Program.TeslaList)
            {
                Console.WriteLine($"Modelo: {t.Modelo}, Año: {t.Anio}, Kilometraje: {t.KmActual}, Dueño: {t.Dueno}");
            }
        }
    }
}
