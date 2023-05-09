using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeslaSystem
{
    public class Eliminar
    {
        //Función para dar de alta un nuevo Tesla en la lista
        public static void EliminarTesla()
        {
            Console.WriteLine("\n\nIngrese el indice del Tesla a eliminar:");
            int indice = Convert.ToInt32(Console.ReadLine());

            if (indice < Program.TeslaList.Count)
            {
                Program.TeslaList.RemoveAt(indice);
                Console.WriteLine("Tesla eliminado exitosamente!");
            }
            else
            {
                Console.WriteLine("Indice invalido.");
            }
        }
    }
}
