//Programa para calcular el producto de dos números introducidos por el usuario
using System;

namespace ejercicio_1_10_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int primerNumero;
            int segundoNumero;
            int producto;

            Console.WriteLine("Introduce el primer número");
            primerNumero = Convert.ToInt32(
                Console.ReadLine());

            Console.WriteLine("Introduce el segundo número");
            segundoNumero = Convert.ToInt32(
                Console.ReadLine());

            producto = primerNumero * segundoNumero;

            Console.WriteLine("El producto de {0} * {1} da como resultado {2}",
                primerNumero, segundoNumero, producto);
        }
    }
}
