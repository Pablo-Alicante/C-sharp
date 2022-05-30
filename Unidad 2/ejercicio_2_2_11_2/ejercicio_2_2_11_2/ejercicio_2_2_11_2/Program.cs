using System;

namespace ejercicio_2_2_11_2
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int contador=2;contador<=106;contador=contador+2)
            {
                if (contador % 10 == 0)
                    continue;

                Console.WriteLine("{0}", contador);
            }
        }
    }
}
