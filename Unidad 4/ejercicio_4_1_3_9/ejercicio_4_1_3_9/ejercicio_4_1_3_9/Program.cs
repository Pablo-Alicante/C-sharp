using System;

namespace ejercicio_4_1_3_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vectorX = new int[3];
            int[] vectorY = new int[3];
            int suma1;
            int suma2;
            int suma3;
            int sumaTotal;

            Console.WriteLine("El programa le pedirá valores para 2 vectores de 3 componentes cada uno.\nDespués calculará la suma de ambos vectores.");

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

            Console.WriteLine();

            suma1 = vectorX[0] + vectorY[0];
            suma2 = vectorX[1] + vectorY[1];
            suma3 = vectorX[2] + vectorY[2];

            sumaTotal = suma1 + suma2 + suma3;
            
            Console.WriteLine("La suma de ambos vectores es {0}.", sumaTotal);
        }
    }
}
