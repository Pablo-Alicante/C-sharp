using System;

namespace ejercicio_3_2_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 5;
            Console.WriteLine("a vale {0}.", a);

            a /= 2;
            Console.WriteLine("Ahora a vale {0}.", a);

            a += 1;
            Console.WriteLine("Ahora a vale {0}.", a);

            a *= 3;
            Console.WriteLine("Ahora a vale {0}.", a);

            --a;
            Console.WriteLine("Ahora a vale {0}.", a);
        }
    }
}
