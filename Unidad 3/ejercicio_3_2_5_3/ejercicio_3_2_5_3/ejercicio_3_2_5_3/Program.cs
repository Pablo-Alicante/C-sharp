using System;

namespace ejercicio_3_2_5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Datos del rectángulo
            float ladoBase;
            float ladoAltura;

            //Datos a calcular
            float perimetro;
            float area;
            double diagonal;

            Console.WriteLine("El programa calculará el perímetro, el área y la diagonal de un rectángulo.");

            Console.WriteLine();

            Console.Write("Aporte un valor para la base: ");
            ladoBase = Convert.ToSingle(Console.ReadLine());
            Console.Write("Aporte un valor para la altura: ");
            ladoAltura = Convert.ToSingle(Console.ReadLine());

            perimetro = (ladoBase * 2) + (ladoAltura * 2);
            area = ladoBase * ladoAltura;
            diagonal = Math.Sqrt(Math.Pow(ladoBase, 2) + Math.Pow(ladoAltura, 2));

            Console.WriteLine();

            Console.WriteLine("El perímetro del rectángulo es:");
            Console.WriteLine(perimetro.ToString("0.0"));
            Console.WriteLine("El área del rectángulo es:");
            Console.WriteLine(area.ToString("0.0"));
            Console.WriteLine("La diagonal del rectángulo es:");
            Console.WriteLine(diagonal.ToString("0.0"));
        }
    }
}
