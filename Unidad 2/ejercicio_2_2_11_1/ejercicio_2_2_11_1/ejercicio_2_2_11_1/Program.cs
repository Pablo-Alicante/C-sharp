using System;

namespace ejercicio_2_2_11_1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int contador=20;contador>=10;contador--)
            {
                if (contador == 13)
                    continue;

                Console.WriteLine("{0}",contador);
            }
        }
    }
}
