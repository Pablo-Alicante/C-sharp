using System;
using System.Linq;

namespace ejercicio_4_1_3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] año = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int mesUsuario;
            int diaUsuario;
            int sumaDias = 0;

            Console.WriteLine("El programa le pedirá que le indique un mes y un día.\nDespués le dirá que número de día es dentro del año.");

            Console.WriteLine();

            Console.Write("Seleccione un mes: ");
            mesUsuario = Convert.ToInt32(Console.ReadLine());

            Console.Write("Seleccione un día: ");
            diaUsuario = Convert.ToInt32(Console.ReadLine());

            mesUsuario--;

            for(int i=0;i<mesUsuario;i++)
            { 
                sumaDias += año[i];
            }

            sumaDias += diaUsuario;

            Console.WriteLine();

            Console.WriteLine("Corresponde al día número {0} del año.",sumaDias-1);
        }
    }
}
