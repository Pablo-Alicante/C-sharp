using System;

namespace ejercicio_3_2_3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            float euros = 1000;
            float intereses = 3;
            float años = 10;
            double resultado;

            Console.WriteLine("El siguiente programa calculará la fórmula del interés compuesto: e(1+i)^n.");
            Console.WriteLine("Se calculará en cuanto se convertirán 1000 euros al cabo de 10 años al 3% de interés anual.");

            resultado = euros * Math.Pow((1 + intereses), años);

            Console.WriteLine();

            Console.Write("1000 euros al cabo de 10 años al 3% de interés anual se convertirán en: ");
            Console.WriteLine(resultado.ToString("0.000"));

        }
    }
}
