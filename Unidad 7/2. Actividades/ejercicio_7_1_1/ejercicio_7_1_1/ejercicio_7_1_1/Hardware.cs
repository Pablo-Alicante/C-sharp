using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_7_1_1
{
    class Hardware
    {
        public static void EscribirCentrado(string textoUsuario)
        {
            Console.SetCursorPosition((Console.WindowWidth - textoUsuario.Length) / 2, Console.CursorTop);
            Console.WriteLine(textoUsuario);
        }
    }
}
