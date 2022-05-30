using System;

namespace ejercicio_2_2_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int tabla=1;
            int numero;

            while (tabla<=4)
            {
                for(tabla=1;tabla<=4;tabla++)
                     for (numero = 1; numero <= 5; numero++)
                     Console.Write("{0}", numero);
            }
        }
    }
}
