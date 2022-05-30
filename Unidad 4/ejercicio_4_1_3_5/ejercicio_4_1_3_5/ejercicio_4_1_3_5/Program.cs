using System;
using System.Linq;

namespace ejercicio_4_1_3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] año = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int mesUsuario;
            int diaUsuario;
            int contadorDias = 0;
            int diasRestantes;

            Console.WriteLine("El programa le pedirá que le indique un mes y un día.\nDespués le dirá que número de día es dentro del año.");

            Console.WriteLine();

            Console.Write("Seleccione un mes: ");
            mesUsuario = Convert.ToInt32(Console.ReadLine());

            Console.Write("Seleccione un día: ");
            diaUsuario = Convert.ToInt32(Console.ReadLine());

            mesUsuario--;

            for (int i = 0; i < mesUsuario; i++)
            {
                contadorDias += año[i];
            }

            contadorDias += diaUsuario;

            diasRestantes = año.Sum() - contadorDias;
            
            Console.WriteLine();

            Console.WriteLine("Quedan {0} dias para finalizar el año.",diasRestantes);
        }
    }
}
