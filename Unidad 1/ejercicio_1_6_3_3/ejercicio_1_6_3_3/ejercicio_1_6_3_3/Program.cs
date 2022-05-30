using System;

namespace ejercicio_1_6_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int primerNumero;
            int segundoNumero;
            int resto;

            primerNumero = 3784;
            segundoNumero = 16;
            resto = primerNumero % segundoNumero;

            Console.WriteLine("El resto de {0} y {1} es {2}",
                primerNumero, segundoNumero, resto);
        }
    }
}
