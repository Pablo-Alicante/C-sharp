using System;

namespace ejercicio_1_9_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int primerNumero;
            int resultado;

            Console.WriteLine("Introduzca la cantidad de millas náuticas que desea convertir");
            primerNumero = Convert.ToInt32(
                Console.ReadLine());

            resultado = primerNumero * 1852;

            Console.WriteLine("{0} millas naúticas equivalen a {1} metros",
                primerNumero, resultado);
        }
    }
}
