using System;

namespace ejercicio_2_7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            int añoNacimiento;

            try
            {
                Console.Write("Introduzca su edad: ");
                edad = Convert.ToInt32(Console.ReadLine());
            }
            catch(FormatException)
            {
                Console.WriteLine("Error.No es un número válido.");
            }

            Console.Write("Introduzca su año de nacimiento: ");
            añoNacimiento = Convert.ToInt32(Console.ReadLine());
        }
    }
}
