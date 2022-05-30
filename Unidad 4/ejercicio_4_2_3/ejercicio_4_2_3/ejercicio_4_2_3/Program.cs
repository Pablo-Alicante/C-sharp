using System;

namespace ejercicio_4_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] numeros = new int[2][];

            //Tamaño de cada bloque.

            int valorBloque1;
            int valorBloque2;

            Console.WriteLine("El programa le preguntará el tamaño que quiere que tengan los dos bloques. \nDespués, pedirá datos para ambos bloques y mostrará el mayor de cada uno de ellos.");

            Console.WriteLine();

            Console.Write("¿De qué tamaño desea el primer bloque?: ");
            valorBloque1 = Convert.ToInt32(Console.ReadLine());

            numeros[0] = new int[valorBloque1]; //Se introduce el tamaño del primer bloque.

            Console.WriteLine();

            Console.Write("¿De qué tamaño desea el segundo bloque?: ");
            valorBloque2 = Convert.ToInt32(Console.ReadLine());

            numeros[1] = new int[valorBloque2]; //Se introduce el tamaño del segundo bloque.

            Console.WriteLine();

            for (int i = 0; i < valorBloque1; i++)
            {
                for (int j = 0; j < valorBloque2; j++)
                {
                    Console.Write("Introduzca nombre: ");
                    numeros[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
    }
}
