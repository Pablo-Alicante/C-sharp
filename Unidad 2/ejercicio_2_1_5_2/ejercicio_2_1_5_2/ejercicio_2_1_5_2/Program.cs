using System;

namespace ejercicio_2_1_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Introduzca un número:");
            numero = Convert.ToInt32(
                Console.ReadLine());

            if ((numero % 2 == 0) && (numero % 3 == 0))
                Console.WriteLine("El número introducido es múltiplo de 2 y de 3");
        }
    }
}
