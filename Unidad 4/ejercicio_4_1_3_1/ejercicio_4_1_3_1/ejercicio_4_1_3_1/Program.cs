using System;

namespace ejercicio_4_1_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            short[] numeros = new short[6];

            Console.WriteLine("El programa le pedirá 6 números y los mostrará en orden inverso.");

            Console.WriteLine();

            Console.Write("Introduzca el primer número: ");
            numeros[0] = Convert.ToInt16(Console.ReadLine());

            Console.Write("Introduzca el segundo número: ");
            numeros[1] = Convert.ToInt16(Console.ReadLine());

            Console.Write("Introduzca el tercer número: ");
            numeros[2] = Convert.ToInt16(Console.ReadLine());

            Console.Write("Introduzca el cuarto número: ");
            numeros[3] = Convert.ToInt16(Console.ReadLine());

            Console.Write("Introduzca el quinto número: ");
            numeros[4] = Convert.ToInt16(Console.ReadLine());

            Console.Write("Introduzca el sexto número: ");
            numeros[5] = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine();

            for (short i = 5; i > -1; i--)
            {
                Console.WriteLine(numeros[i]);
            }
        }
    }
}
