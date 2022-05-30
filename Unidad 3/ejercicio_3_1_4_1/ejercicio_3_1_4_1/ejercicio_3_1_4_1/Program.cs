using System;

namespace ejercicio_3_1_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 15;
            int y = -10;
            int z = 214;

            Console.WriteLine("X vale {0}", x);
            x *= 12;
            Console.WriteLine("Tra incrementar su valor en 12, ahora X vale {0}.", x);

            Console.WriteLine("Y vale {0}", y);
            y *= 12;
            Console.WriteLine("Tra incrementar su valor en 12, ahora Y vale {0}.", y);

            Console.WriteLine("Z vale {0}", z);
            z *= 12;
            Console.WriteLine("Tra incrementar su valor en 12, ahora Z vale {0}.", z);
        }
    }
}
