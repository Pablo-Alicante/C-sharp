using System;

namespace ejercicio_2_1_8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int valorAbsoluto;

            Console.Write("Introduzca un número del que desee saber su valor absoluto: ");
            numero = Convert.ToInt32(Console.ReadLine());

            valorAbsoluto = numero > 0 ? numero : -numero;

            Console.WriteLine("El valor absoluto de {0} es {1}.", numero, valorAbsoluto);
        }
    }
}
