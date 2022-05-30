using System;

namespace ejercicio_7_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int nFichas = 0;
            int opcion;
            Libro[] libro = new Libro[1000];

            do
            {
                Console.WriteLine();

                Console.WriteLine("Introduzca una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                switch (opcion)
                {
                    case 1: libro./*---*/; break;
                    case 2: libro./*---*/; break;
                    case 3: Console.WriteLine("Fin del programa"); break;
                    default: Console.WriteLine("¡Opción desconocida!"); break;
                }
            }
            while (opcion != 3);
        }
    }
}
