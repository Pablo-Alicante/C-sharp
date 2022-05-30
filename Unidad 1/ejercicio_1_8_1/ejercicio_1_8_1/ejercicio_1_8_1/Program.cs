using System;

namespace ejercicio_1_8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Programa para pasar 3000 metros a millas*/

            int primerNumero;
            int segundoNumero;
            int tercerNumero;
            int resultado;

            primerNumero = 1;
            segundoNumero = 1609;
            tercerNumero = 3000;
            resultado = primerNumero * tercerNumero / segundoNumero;

            Console.WriteLine("La conversión de pasar {0} metros a millas, da como resultado {1} millas",
                tercerNumero, resultado);





        }
    }
}
