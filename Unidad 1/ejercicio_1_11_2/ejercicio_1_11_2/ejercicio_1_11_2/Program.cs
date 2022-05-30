using System;

namespace ejercicio_1_11_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int primerNumero;
            int uno;
            int dos;
            int tres;
            int cuatro;
            int cinco;
            int seis;
            int siete;
            int ocho;
            int nueve;
            int diez;
            int resultado1;
            int resultado2;
            int resultado3;
            int resultado4;
            int resultado5;
            int resultado6;
            int resultado7;
            int resultado8;
            int resultado9;
            int resultado10;

            Console.Write("Introduzca un número para mostrar su tabla de multiplicar: ");
            primerNumero = Convert.ToInt32(
                Console.ReadLine());

            uno = 1;
            dos = 2;
            tres = 3;
            cuatro = 4;
            cinco = 5;
            seis = 6;
            siete = 7;
            ocho = 8;
            nueve = 9;
            diez = 10;

            resultado1 = primerNumero * 1;
            resultado2 = primerNumero * 2;
            resultado3 = primerNumero * 3;
            resultado4 = primerNumero * 4;
            resultado5 = primerNumero * 5;
            resultado6 = primerNumero * 6;
            resultado7 = primerNumero * 7;
            resultado8 = primerNumero * 8;
            resultado9 = primerNumero * 9;
            resultado10 = primerNumero * 10;

            Console.WriteLine("Su tabla de multiplicar es la siguiente:");
            Console.WriteLine("{0} * {1} = {2}",
                primerNumero, uno, resultado1);
            Console.WriteLine("{0} * {1} = {2}",
                primerNumero, dos, resultado2);
            Console.WriteLine("{0} * {1} = {2}",
                primerNumero, tres, resultado3);
            Console.WriteLine("{0} * {1} = {2}",
                primerNumero, cuatro, resultado4);
            Console.WriteLine("{0} * {1} = {2}",
                primerNumero, cinco, resultado5);
            Console.WriteLine("{0} * {1} = {2}",
                primerNumero, seis, resultado6);
            Console.WriteLine("{0} * {1} = {2}",
                primerNumero, siete, resultado7);
            Console.WriteLine("{0} * {1} = {2}",
                primerNumero, ocho, resultado8);
            Console.WriteLine("{0} * {1} = {2}",
                primerNumero, nueve, resultado9);
            Console.WriteLine("{0} * {1} = {2}",
                primerNumero, diez, resultado10);

        }
    }
}
