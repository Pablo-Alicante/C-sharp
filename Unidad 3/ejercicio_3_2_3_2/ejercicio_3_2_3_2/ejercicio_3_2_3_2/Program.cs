using System;

namespace ejercicio_3_2_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            float distancia;
            float tiempoHoras;
            float tiempoMinutos;
            float tiempoSegundos;
            float velocidadMS;
            float velocidadKH;
            float velocidadMH;

            Console.WriteLine("Introduzca la distancia que desea recorrer.");
            Console.Write("Metros: ");
            distancia = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Introduzca el tiempo en el que desea recorrer esa distancia.");
            Console.Write("Horas: ");
            tiempoHoras= Convert.ToSingle(Console.ReadLine());
            Console.Write("Minutos: ");
            tiempoMinutos = Convert.ToSingle(Console.ReadLine());
            Console.Write("Segundos: ");
            tiempoSegundos = Convert.ToSingle(Console.ReadLine());

            velocidadMS = distancia / ((tiempoHoras * 3600) + (tiempoMinutos * 60) + tiempoSegundos);
            velocidadKH = (distancia / 1000) / (tiempoHoras + (tiempoMinutos / 60) + (tiempoSegundos / 3600));
            velocidadMH = (distancia / 1609) / (tiempoHoras + (tiempoMinutos / 60) + (tiempoSegundos / 3600));

            Console.WriteLine();

            Console.WriteLine("Para recorrer {0} metros en un tiempo de {1} horas, {2} minutos y {3} segundos, se necesita ir a una velocidad de:",distancia,tiempoHoras,tiempoMinutos,tiempoSegundos);
            Console.WriteLine("{0} m/s", velocidadMS);
            Console.WriteLine("{0} Km/h", velocidadKH);
            Console.WriteLine("{0} mi/h", velocidadMH);
        }
    }
}
