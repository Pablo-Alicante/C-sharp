using System;

namespace ejercicio_3_2_6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int fila=0; fila <= 255; fila++)
            {
                switch(fila)
                {
                    case 16:
                    case 31:
                    case 47:
                    case 63:
                    case 79:
                    case 95:
                    case 111:
                    case 127:
                    case 143:
                    case 159:
                    case 175:
                    case 191:
                    case 207:
                    case 223:
                    case 239:Console.WriteLine();
                        break;
                }

                Console.Write(Convert.ToString(fila,16));
            }
        }
    }
}
