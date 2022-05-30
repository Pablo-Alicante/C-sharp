using System;

namespace ejercicio_2_1_9_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.Write("Introduzca un número del 1 al 5: ");
            numero = Convert.ToInt32(Console.ReadLine());

            switch(numero)
            {
                case 1:Console.WriteLine("uno");
                    break;
                case 2:Console.WriteLine("dos");
                    break;
                case 3:Console.WriteLine("tres");
                    break;
                case 4:Console.WriteLine("cuatro");
                    break;
                case 5:Console.WriteLine("cinco");
                    break;
            }
        }
    }
}
