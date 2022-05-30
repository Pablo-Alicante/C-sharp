using System;

namespace ejercicio_3_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string usuario;
            string clave1;
            string clave2;

            Console.WriteLine("El programa le pedirá su usuario y su contraseña.");

            Console.WriteLine();

            Console.Write("Usuario: ");
            usuario = Console.ReadLine();

            Console.Write("Contraseña: ");
            clave1 = Console.ReadLine();

            Console.Write("Vuelva a introducir su contraseña para confirmar: ");
            clave2 = Console.ReadLine();

            Console.WriteLine();

            if (clave2 == clave1)
            {
                Console.WriteLine("Acceso permitido.");
                Console.WriteLine("Bienvenido {0}.", usuario);
            }

            while (clave2!=clave1)
            {
                Console.WriteLine("Acceso denegado. La contraseña no es la misma.");
                Console.WriteLine("Inténtelo de nuevo.");

                Console.WriteLine();

                Console.Write("Contraseña: ");
                clave1 = Console.ReadLine();

                Console.Write("Vuelva a introducir su contraseña: ");
                clave2 = Console.ReadLine();

                Console.WriteLine();

                if (clave2 == clave1)
                {
                    Console.WriteLine("Acceso permitido.");
                    Console.WriteLine("Bienvenido {0}.", usuario);
                }
            }
        }
    }
}
