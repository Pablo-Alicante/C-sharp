using System;

namespace ejercicio_3_2_3_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            double y;

            Console.WriteLine("El programa creará la gráfica de y = (x-5)^2 para valores de x entre 1 y 10.");

            Console.WriteLine();

            for (x = 1; x <= 10; x++)
            {
                y = Math.Pow((x - 5), 2);
                {
                    Console.WriteLine(" *");
                }
                Console.Write('*');
            }
        }
    }
}
