using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5Fichero.Servicios
{
    /// <summary>
    /// Clase que implementa a la interfaz de los menus de la aplicacion
    /// irodhan -> 22/03/2024
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public int mostrarMenuYSeleccion()
        {
            Console.WriteLine("|------------------------|");
            Console.WriteLine("|          Menú          |");
            Console.WriteLine("|________________________|");
            Console.WriteLine("| 0. Cerrar aplicacion   |");
            Console.WriteLine("| 1. Modificar linea     |");
            Console.WriteLine("| 2. Insertar texto      |");
            Console.WriteLine("|________________________|");
            Console.WriteLine("\nIntroduzca la opcion deseada:");
            int opcion = Console.ReadKey(true).KeyChar - ('0');
            return opcion;
        }
    }
}
