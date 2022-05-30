//Isabella 17/09/2020
using System;

namespace ejercicio_1_10_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int primerNumero;
            int segundoNumero;
            int resultado;
            int resto;

            Console.WriteLine("Introduce el primer número");
            primerNumero = Convert.ToInt32(
                Console.ReadLine());

            Console.WriteLine("Introduce el segundo número");
            segundoNumero = Convert.ToInt32(
                Console.ReadLine());

            resultado = primerNumero / segundoNumero;

            resto = primerNumero % segundoNumero;

            Console.WriteLine("La división {0} : {1} da como resultado {2} y su resto es {3}",
                primerNumero, segundoNumero, resultado, resto);
        }
    }
}
