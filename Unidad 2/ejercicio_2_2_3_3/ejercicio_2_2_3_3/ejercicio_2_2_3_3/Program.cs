using System;

namespace ejercicio_2_2_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador;

            for(contador=100;contador<=200; contador=contador+1)
            {
                if ((contador % 3 == 0) && (contador % 7 == 0))
                    Console.WriteLine("{0}", contador);
            }
        }
    }
}
