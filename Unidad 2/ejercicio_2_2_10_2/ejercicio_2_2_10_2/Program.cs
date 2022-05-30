using System;

namespace ejercicio_2_2_10_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;
            int n2;
            int max;
            int mcm=0;

            Console.Write("Introduzca un número: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduzca otro número: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            max = (n1 < n2 ? n2 : n1);

            for (int i=1;i<=max;i++)
            {
                if((n1%i==0)&&(n2%i==0))
                {
                    int mcd = i;

                    mcm = (n1 * n2) / mcd;

                    break;
                }
            }

            Console.WriteLine("El mínimo común múltiplo de ambos número es {0}.",mcm);
        }
    }
}
