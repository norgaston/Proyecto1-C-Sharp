using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TeslaSystem
{
    public class Alta
    {

        //Función para dar de alta un nuevo Tesla en la lista
        public static void DarDeAlta()
        {
            // Crear un nuevo Tesla y pedir al usuario que ingrese sus detalles
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

            //////Agregar el nuevo Tesla a la lista
            //return nuevoTesla;


            // Agregar el nuevo Tesla a la lista
            Program.TeslaList.Add(nuevoTesla);
            Console.WriteLine("Tesla agregado exitosamente!");
        }
    }
}
