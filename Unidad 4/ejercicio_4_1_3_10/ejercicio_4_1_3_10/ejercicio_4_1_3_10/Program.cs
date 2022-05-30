using System;

namespace ejercicio_4_1_3_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vectorX = new int[3];
            int[] vectorY = new int[3];
            int productoEscalar = 0;

            Console.WriteLine("El programa le pedirá que introduzca valores para los 3 componentes que componen los dos vectores(X,Y). \nDespués, calculará el producto escalar.");

            Console.WriteLine();

            for(int i=0;i<3;i++)
            {
                Console.Write("Introduzca un valor para el componente del vector X: ");
                vectorX[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();

            for(int j=0;j<3;j++)
            {
                Console.Write("Introduzca un valor para el componente del vector Y: ");
                vectorY[j] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i=0;i<3;i++)
            {
                productoEscalar = productoEscalar + (vectorX[i] * vectorY[i]);
            }

            Console.WriteLine();

            Console.WriteLine("El producto escalar es {0}.", productoEscalar);
        }
    }
}
