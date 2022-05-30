using System;

namespace ejercicio_2_2_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int tabla;
            int numero;

            for (tabla = 1; tabla <= 4; tabla++)
                for (numero = 1; numero <= 5; numero++)
                    Console.Write("{0}", numero);
        }
    }
}
