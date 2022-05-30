using System;

namespace ejercicio_2_2_7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            char letra;
            int contador;

            for(contador=1;contador<=5;contador++)
            {
                for (letra = 'L'; letra <= 'N'; letra++)
                    Console.Write("{0}", letra);
            }
        }
    }
}
