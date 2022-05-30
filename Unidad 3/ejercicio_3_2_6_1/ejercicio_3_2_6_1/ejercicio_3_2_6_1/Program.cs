using System;

namespace ejercicio_3_2_6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("El programa le mostrará el número que introduzca en sistema binario y hexadecimal.");
            Console.WriteLine("Para salir introduzca 0.");

            Console.WriteLine();

            Console.Write("Introduzca un número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            while (numero!=0)
            {
                Console.WriteLine("El número {0} en sistema binario es:",numero);
                Console.WriteLine(Convert.ToString(numero, 2));
                Console.WriteLine("El número {0} en sistema hexadecimal es:",numero);
                Console.WriteLine(Convert.ToString(numero, 16));

                Console.WriteLine();

                Console.Write("Introduzca un número: ");
                numero = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
