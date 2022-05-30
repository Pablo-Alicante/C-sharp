using System;

namespace ejercicio_3_2_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            double h;
            double y1;
            double y2;

            Console.Write("Introduzca un valor para a: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduzca un valor para b: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduzca un valor para c: ");
            c = Convert.ToInt32(Console.ReadLine());

            h = Math.Sqrt(b * b - 4 * a * c);

            if (Double.IsNaN(h))
            {
                Console.WriteLine("Error negativo.");
            }
            else
            {
                y1 = (-b + h) / 2 * a;

                y2 = (-b - h) / 2 * a;

                Console.WriteLine("{0}x2+{1}x+{2}=0", a, b, c);

                Console.WriteLine("y1 = {0}", y1);

                Console.WriteLine("y2 = {0}", y2);
            }

        }
    }
}
