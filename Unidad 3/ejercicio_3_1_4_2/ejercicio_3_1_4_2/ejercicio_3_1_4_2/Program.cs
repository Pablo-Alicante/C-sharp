using System;

namespace ejercicio_3_1_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            Console.WriteLine("a vale {0}.", a);

            int b = a+2;
            Console.WriteLine("b vale {0}.", b);

            b -= 3;
            Console.WriteLine("b ahora vale {0}.", b);

            int c = -3;
            Console.WriteLine("c vale {0}.", c);

            c *= 2;
            Console.WriteLine("Ahora c vale {0}.", c);

            ++c;
            Console.WriteLine("Ahora c vale {0}.", c);

            a *= b;
            Console.WriteLine("Ahora a vale {0}.", a);
        }
    }
}
