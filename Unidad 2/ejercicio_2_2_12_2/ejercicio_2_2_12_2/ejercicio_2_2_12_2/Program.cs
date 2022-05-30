using System;

namespace ejercicio_2_2_12_2
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int contador=20;contador>=10;contador--)
            {
                if (contador == 14)
                    continue;
                Console.Write("{0} ", contador);
            }
            Console.WriteLine();

            int n=20;
            while(n>=10)
            {
                if (n == 14)
                    continue;

                Console.Write("{0} ", n);
                n--;
            }
        }
    }
}
