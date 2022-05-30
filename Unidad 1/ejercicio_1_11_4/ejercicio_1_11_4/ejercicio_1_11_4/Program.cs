using System;

namespace ejercicio_1_11_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int kelvin;
            int fahrenheit;

            Console.Write("Introdcuza el número de grados Celsius que desea convertir: ");
            numero = Convert.ToInt32(
                Console.ReadLine());

            kelvin = numero + 273;

            fahrenheit = numero * 18 / 10 + 32;

            Console.Write(numero);
            Console.Write(" grados Celsius equivalen a ");
            Console.Write(kelvin);
            Console.Write(" grados Kelvin y a ");
            Console.Write(fahrenheit);
            Console.Write(" grados Fahrenheit");
        }
    }
}
