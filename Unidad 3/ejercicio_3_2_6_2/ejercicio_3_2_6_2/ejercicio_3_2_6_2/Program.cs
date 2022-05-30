using System;

namespace ejercicio_3_2_6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            byte rojo;
            byte verde;
            byte azul;
            short RGB;

            Console.WriteLine("El programa le pedirá que introduzca una cantidad de cada color indicado.");
            Console.WriteLine("Después ese color RGB se mostrará en notación hexadecimal.");
            Console.WriteLine("Recuerde que la cantidad máxima que se puede introducir es 255.");

            Console.WriteLine();

            Console.Write("Introduzca una cantidad para el color rojo: ");
            rojo = Convert.ToByte(Console.ReadLine());
            Console.Write("Introduzca una cantidad para el color verde: ");
            verde = Convert.ToByte(Console.ReadLine());
            Console.Write("Introduzca una cantidad para el color azul: ");
            azul = Convert.ToByte(Console.ReadLine());

            RGB =(short)(rojo + verde + azul);

            Console.WriteLine();

            Console.WriteLine("El color introducido se representa en notación hexadecimal como:");
            Console.WriteLine(Convert.ToString(RGB, 16));
        }
    }
}
