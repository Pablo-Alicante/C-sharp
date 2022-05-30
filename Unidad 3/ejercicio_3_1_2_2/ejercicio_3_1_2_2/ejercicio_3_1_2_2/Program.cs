using System;

namespace ejercicio_3_1_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n1;
            byte n2;
            ushort resultado;

            Console.Write("Introduzca un número: ");
            n1 = Convert.ToByte(Console.ReadLine());

            Console.Write("Introduzca otro número: ");
            n2 = Convert.ToByte(Console.ReadLine());

            resultado = Convert.ToUInt16(n1 * n2);

            Console.WriteLine("{0} * {1} = {2}", n1, n2, resultado);
        }
    }
}
