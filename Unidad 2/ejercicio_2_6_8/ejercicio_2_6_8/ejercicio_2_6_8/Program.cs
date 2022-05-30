using System;

namespace ejercicio_2_6_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int precio;
            int pago;
            int cambio;

            Console.Write("¿Precio?: ");
            precio = Convert.ToInt32(Console.ReadLine());

            Console.Write("¿Pagado?: ");
            pago = Convert.ToInt32(Console.ReadLine());

            cambio = pago - precio;


        }
    }
}
