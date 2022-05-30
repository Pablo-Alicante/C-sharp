using System;

namespace ejercicio_1_6_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int primerNumero;
            int segundoNumero;
            int producto;

            primerNumero = 121;
            segundoNumero = 132;
            producto = primerNumero * segundoNumero;

            Console.WriteLine("El producto de {0} y {1} es {2}",
                primerNumero, segundoNumero, producto);

        }
    }
}
