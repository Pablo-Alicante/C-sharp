using System;

namespace ejercicio_1_7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;
            int producto;

            numero1 = 87;
            numero2 = 94;
            producto = numero1 * numero2;

            Console.WriteLine("El producto de {0} * {1} es {2}",
                numero1, numero2, producto);
        }
    }
}
