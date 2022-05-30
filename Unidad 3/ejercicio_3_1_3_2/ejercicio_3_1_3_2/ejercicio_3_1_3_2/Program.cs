using System;

namespace ejercicio_3_1_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            Console.WriteLine("a vale {0}.", a);

            int b = ++a;
            Console.WriteLine("b vale {0}.", b);

            int c = a++;
            Console.WriteLine("c vale {0}.", c);

            b = b * 5;
            Console.WriteLine("Ahora b vale {0}.", b);

            a = a * 2;
            Console.WriteLine("Ahora a vale {0}.", a);
        }
    }
}
