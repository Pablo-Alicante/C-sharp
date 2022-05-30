using System;

namespace ejercicio_4_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] datos = new int[2, 10];
            int maximo = datos[0,0];

            Console.WriteLine("El programa le pedirá que introduzca dos bloques de 10 números enteros cada uno. \nDespués,mostrará el mayor dato que se ha introducido en cada uno de ellos.");

            Console.WriteLine();

            for(int i=0;i<2;i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write("Introduzca un número para el bloque: ");
                    datos[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (datos[i, j] > maximo)
                    {
                        maximo = datos[i, j];
                    }
                }
            }

            Console.WriteLine();

            Console.WriteLine("El número mayor es {0}.", maximo);
        }
    }
}
