using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuReceta.Servicios
{
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Método que muestra el mensaje de bienvenida
        /// </summary>
        void MensajeBienvenida();

        /// <summary>
        /// Metodo que muestra el menú con las opciones
        /// </summary>
        /// <returns></returns>
        public int MostrarMenu();
    }
}
