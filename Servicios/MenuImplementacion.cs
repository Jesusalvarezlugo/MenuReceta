using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuReceta.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public void MensajeBienvenida()
        {
            string mensaje = "Bienvenido al recetario";

            Console.WriteLine(mensaje);
        }

        public int MostrarMenu()
        {
            int opcion;

            Console.WriteLine("\t\t\t╔══════════════════════════════╗");
            Console.WriteLine("\t\t\t║             MENU             ║");
            Console.WriteLine("\t\t\t╠══════════════════════════════╣");
            Console.WriteLine("\t\t\t║                              ║");
            Console.WriteLine("\t\t\t║    1.- Escribir receta       ║");
            Console.WriteLine("\t\t\t║    2.- Leer receta           ║");
            Console.WriteLine("\t\t\t║                              ║");
            Console.WriteLine("\t\t\t║                              ║");
            Console.WriteLine("\t\t\t║                              ║");
            Console.WriteLine("\t\t\t║          0) Salir            ║");
            Console.WriteLine("\t\t\t║                              ║");
            Console.WriteLine("\t\t\t╚══════════════════════════════╝");
            Console.Write("\t\tIntroduce una opción: ");

            opcion= Console.ReadKey(true).KeyChar - ('0');

            return opcion;
        }
    }
}
