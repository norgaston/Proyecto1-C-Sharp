using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeslaSystem
{
    public class MostrarMasKm
    {
        // Función para mostrar el Tesla con más kilometraje
        public static void MostrarMasKms()
        {
            // Inicializa la variable maxKmTesla con el primer Tesla de la lista.
            Tesla maxKmTesla = Program.TeslaList[0];

            // Recorre la lista de Teslas y actualiza maxKmTesla si encuentra un Tesla con más kilómetros que el actual.
            foreach (Tesla t in Program.TeslaList)
            {
                if (t.KmActual > maxKmTesla.KmActual)
                {
                    maxKmTesla = t;
                }
            }

            // Muestra la información del Tesla con más kilómetros.
            Console.WriteLine($"\n\nEl Tesla con más kilometraje es: {maxKmTesla.Modelo} ({maxKmTesla.Anio}), con {maxKmTesla.KmActual} km.");
        }
    }
}
