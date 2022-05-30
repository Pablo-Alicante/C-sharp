using System;

namespace ejercicio_1_11_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int primerNumero;
            int segundoNumero;
            //Este será el resultado de la operación (a+b)*(a-b)
            int resultado1;
            //Este será el resuñtado de la operación a^2 - b^2
            int resultado2;

            Console.Write("Introduce el primer número: ");
            primerNumero = Convert.ToInt32(
                Console.ReadLine());

            Console.Write("Introduce el segundo número: ");
            segundoNumero = Convert.ToInt32(
                Console.ReadLine());

            resultado1 = (primerNumero + segundoNumero) * (primerNumero - segundoNumero);
            resultado2 = primerNumero ^ 2 - segundoNumero ^ 2;

            Console.Write("El resultado de la operación ({0} + {1}) * ({0} - {1}) es {2}",
                primerNumero, segundoNumero, resultado1);

            Console.Write(" El resultado de la operación {0}^2 - {1}^2 es {2}",
                primerNumero, segundoNumero, resultado2);
        }
    }
}
