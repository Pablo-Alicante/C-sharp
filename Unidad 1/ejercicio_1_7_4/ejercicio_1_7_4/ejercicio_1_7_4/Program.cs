using System;

namespace ejercicio_1_7_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int número1;
            int número2;
            int producto;

            número1 = 87;
            número2 = 94;
            producto = número1 * número2;

            Console.WriteLine("El producto de {0} * {1} es {2}",
                número1, número2, producto);
        }
    }
}
