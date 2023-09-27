
using MenuReceta.Servicios;

namespace MenuReceta
    ///<summary>
    ///Clase que controla el flujo de la aplicación
    ///270923-jal
    /// </summary>

{
    class Program
    {
        /// <summary>
        /// Clase desde donde iniciaremos la aplicación
        /// 270923-jal
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //llamada al método que imprime por pantalla el mensaje 

            //objeto

            MenuInterfaz mi = new MenuImplementacion();

            mi.MensajeBienvenida();

            //variable para controlar salida y entrada del bucle while
            bool opcionCerrar = false;

            //variable para contener la opcion del usuario

            int opcionSeleccionada;

            while (!opcionCerrar)
            {
                opcionSeleccionada = mi.MostrarMenu();

                switch(opcionSeleccionada)
                {
                    case 0:
                        Console.WriteLine("[INFO] Se muestra la opcion 0");
                        opcionCerrar = true;
                        break;

                    case 1:
                        break;
                }
            }


        }
    }
}
