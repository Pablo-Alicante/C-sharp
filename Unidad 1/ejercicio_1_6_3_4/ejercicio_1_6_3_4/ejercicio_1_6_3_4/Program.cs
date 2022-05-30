using System;

namespace ejercicio_1_6_3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;
            int n2;
            int n3;
            int resultado;

            n1 = 3;
            n2 = 4;
            n3 = 5;
            resultado = n1 + n2 * n3;

            Console.WriteLine("El resultado de {0} + {1} * {2} es {3}",
                n1, n2, n3, resultado);
        }
    }
}
