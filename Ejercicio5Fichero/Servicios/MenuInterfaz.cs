using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5Fichero.Servicios
{
    /// <summary>
    /// Interfaz de los menus de la aplicacion
    /// irodhan -> 22/03/2024
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Metodo que muestra y obtiene la opcion deseada del usuario del menu principal
        /// irodhan -> 22/03/2024
        /// </summary>
        /// <returns></returns>
        public int mostrarMenuYSeleccion();
    }
}
