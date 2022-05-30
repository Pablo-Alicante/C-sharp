using System;

namespace ejercicio_2_2_8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int linea=1;linea<=6;linea++)
            {
                for (int numero = 1; numero <= 7; numero++)
                    Console.Write("{0}", numero);

                Console.WriteLine();
            }
        }
    }
}
