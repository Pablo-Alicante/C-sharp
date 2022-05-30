using System;

namespace ejercicio_4_1_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] numeros = new float[5];

            Console.WriteLine("El programa le pedirá 5 números y luego los muestrará en el orden contrario al que se introdujeron.");

            Console.WriteLine();

            Console.Write("Introduzca el primer número: ");
            numeros[0] = Convert.ToSingle(Console.ReadLine());

            Console.Write("Introduzca el segundo número: ");
            numeros[1] = Convert.ToSingle(Console.ReadLine());

            Console.Write("Introduzca el tercer número: ");
            numeros[2] = Convert.ToSingle(Console.ReadLine());

            Console.Write("Introduzca el cuarto número: ");
            numeros[3] = Convert.ToSingle(Console.ReadLine());

            Console.Write("Introduzca el quinto número: ");
            numeros[4] = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Los números introducidos son {0}, {1}, {2}, {3} y {4}", numeros[0], numeros[1], numeros[2], numeros[3], numeros[4]);
            Console.WriteLine("En el orden contrario serían {0}, {1}, {2}, {3} y {4}", numeros[4], numeros[3], numeros[2], numeros[1], numeros[0]);
        }
    }
}
