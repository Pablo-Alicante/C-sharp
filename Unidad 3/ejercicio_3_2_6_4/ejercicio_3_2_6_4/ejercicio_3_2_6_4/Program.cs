using System;

namespace ejercicio_3_2_6_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string numero;

            Console.WriteLine("El programa le pedirá un número binario y mostrará su equivalente en sistema hexadecimal y decimal.");
            Console.WriteLine("Si desea salir, introduzca la palabra \"fin\".");

            Console.WriteLine();

            Console.Write("Introduzca un número binario: ");
            numero = Console.ReadLine();

            Console.WriteLine();

            while(numero!="fin")
            {
                int n = Convert.ToInt32(numero, 2);

                Console.Write("El número {0} equivale en sistema decimal a: ", numero);
                Console.WriteLine(Convert.ToString(n, 10));
                
                Console.Write("El número {0} equivale en sistema hexadecimal a: ",numero);
                Console.WriteLine(Convert.ToString(n, 16).ToUpper());

                Console.WriteLine();

                Console.Write("Introduzca un número binario: ");
                numero = Console.ReadLine();
            }
        }
    }
}
