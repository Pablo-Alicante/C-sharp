using System;

namespace ejercicio_4_1_3_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = new string[100];
            ConsoleKeyInfo tecla;

            Console.WriteLine("El programa le pedirá que vaya introduciendo un nombre cada vez.\nSi pulsa \"Intro\", le dejará de pedir nombres y mostrará aquellos que haya introducido.");

            Console.WriteLine();

            for (int i = 0; i < 100)
            {
                zz

                Console.Write("Introduzca un nombre: ");
                nombres[i] = Convert.ToString(Console.ReadLine());

                if(tecla.Key==ConsoleKey.Enter)
                {
                    Console.WriteLine("Los nombres introducidos hasta ahora son: \n{0}", nombres[i]);
                }
            }
        }
    }
}
