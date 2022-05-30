using System;

namespace ejercicio_7_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            int opcion;

            menu.Info();

            do
            {
                Console.WriteLine();

                Console.Write("Opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                switch (opcion)
                {
                    case 1: menu.AnadirDatosNuevoFichero(); break;
                    case 2: menu.MostrarNombresFicheros(); break;
                    case 3: menu.MostrarTodosFicheros(); break;
                    case 4: menu.VerDatosFicheros(); break;
                    case 5: Console.WriteLine("Fin del programa"); break;
                    default: Console.WriteLine("¡Opción desconocida!"); break;
                }

            } while (opcion != 5);
        }
    }
}
