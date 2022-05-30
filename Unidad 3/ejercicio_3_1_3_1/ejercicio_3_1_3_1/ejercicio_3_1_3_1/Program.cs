using System;

namespace ejercicio_3_1_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            byte x = 15;
            SByte y = -10;
            uint z= 2147438647;

            Console.WriteLine("X vale {0}", x);
            x++;
            Console.WriteLine("Tras incrementar, ahora vale {0}.", x);

            Console.WriteLine("Y vale {0}", y);
            y++;
            Console.WriteLine("Tras incrementar, ahora vale {0}.", y);

            Console.WriteLine("Z vale {0}", z);
            z++;
            Console.WriteLine("Tras incrementar, ahora vale {0}.", z);
        }
    }
}
