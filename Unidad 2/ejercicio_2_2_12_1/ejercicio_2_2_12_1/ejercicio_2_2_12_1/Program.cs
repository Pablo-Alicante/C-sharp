using System;

namespace ejercicio_2_2_12_1
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int contador=100;contador<=200;contador++)
            {
                Console.Write("{0} ", contador);
            }
            Console.WriteLine();

            int numero = 100;
            while(numero<=200)
            {
                Console.Write("{0} ", numero);
                numero++;
            }
        }
    }
}
