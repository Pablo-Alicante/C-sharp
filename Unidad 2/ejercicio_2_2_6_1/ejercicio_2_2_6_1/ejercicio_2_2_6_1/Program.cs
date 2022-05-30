using System;

namespace ejercicio_2_2_6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int linea;
            int numero;

            for(linea=1;linea<=4;linea++)
            {
                for (numero = 1; numero <= 5; numero++)
                    Console.Write("{0}", numero);

                Console.WriteLine();
            }
        }
    }
}
