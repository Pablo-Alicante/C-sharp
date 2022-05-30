using System;

namespace ejercicio_2_2_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero=26;

            do
            {
                if(numero%2==0)
                Console.WriteLine(numero);
                numero = numero - 1;
            }
            while((numero<27)&&(numero>9));
        }
    }
}
