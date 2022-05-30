using System;

namespace ejercicio_1_9_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int primerNumero;
            int segundoNumero;
            int tercerNumero;
            int resultado;

            Console.WriteLine("Introduce el primer número");
            primerNumero = Convert.ToInt32(
                Console.ReadLine());

            Console.WriteLine("Introduce el segundo número");
            segundoNumero = Convert.ToInt32(
                Console.ReadLine());

            Console.WriteLine("Introduce el tercer número");
            tercerNumero = Convert.ToInt32(
                Console.ReadLine());

            resultado = primerNumero + segundoNumero + tercerNumero;

            Console.WriteLine("La suma de {0} , {1} y {2} da como resultado {3}",
                primerNumero, segundoNumero, tercerNumero, resultado);

        }
    }
}
