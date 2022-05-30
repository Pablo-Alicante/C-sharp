using System;

namespace ejercicio_4_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] nombres = new string[2, 6];
            string nuevoNombre;

            Console.WriteLine("El programa le pedirá que introduzca nombres para los dos bloques. \nDespués,le pedirá que introduzca un nombre y le dirá si aparece en alguno de los dos bloques anteriores.");

            Console.WriteLine();

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write("Introduzca nombre: ");
                    nombres[i, j] = Convert.ToString(Console.ReadLine());
                }
            }

            Console.WriteLine();

            Console.WriteLine("Introduzca un nombre y el programa comprobará si aparece en alguno de los dos bloques de información anteriores.");

            Console.WriteLine();

            Console.Write("Introduzca un nombre: ");
            nuevoNombre = Convert.ToString(Console.ReadLine());

            Console.WriteLine();

            for (int i=0;i<2;i++)
            {
                for(int j=0;j<6;j++)
                {
                    if(nombres[i,j]==nuevoNombre)
                    {
                        Console.WriteLine("El nombre introducido sí se encuentra en alguno de los dos bloques de información anteriores.");
                    }
                }
            }
        }
    }
}
