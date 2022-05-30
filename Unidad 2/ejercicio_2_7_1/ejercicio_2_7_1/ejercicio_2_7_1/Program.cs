using System;

namespace ejercicio_2_7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            int fechaNacimiento;

            try
            {
                Console.Write("Introduzca su edad: ");
                edad = Convert.ToInt32(Console.ReadLine());

                Console.Write("Introduzca su año de nacimiento: ");
                fechaNacimiento = Convert.ToInt32(Console.ReadLine());
            }
            catch(FormatException)
            {
                Console.WriteLine("Error. No es un número válido.");
            }
        }
    }
}
