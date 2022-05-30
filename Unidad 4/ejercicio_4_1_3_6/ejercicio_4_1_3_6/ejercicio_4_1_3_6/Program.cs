using System;

namespace ejercicio_4_1_3_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = new string[10];
            string nombre;

            Console.WriteLine("El programa le pedirá que introduzca 10 nombres.\nDespués pedirá que teclee un nombre y verificará si se encuentra entre ellos.");

            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Introduzca un nombre: ");
                nombres[i] = Convert.ToString(Console.ReadLine());
            }

            Console.WriteLine();

            Console.Write("Teclee un nombre para saber si se encuentra en la base de datos (Teclee \"fin\" para salir): ");
            nombre = Convert.ToString(Console.ReadLine());

            while(nombre!="fin")
            {
                for (int j = 0; j < 10; j++)
                {
                    if (nombre==nombres[j])
                    {
                        Console.WriteLine("El nombre introducido se encuentra en la base de datos.");

                        Console.WriteLine();

                        Console.Write("Teclee un nombre para saber si se encuentra en la base de datos (Teclee \"fin\" para salir): ");
                        nombre = Convert.ToString(Console.ReadLine());
                        
                    }
                }
            }

        }
    }
}
