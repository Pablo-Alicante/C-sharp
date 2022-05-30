using System;
using System.Collections.Generic;
using System.Text;

namespace ejercicio_7_1_2
{
    class Hardware
    {
        public void EscribirCentrado(string textoUsuario)
        {
            Console.SetCursorPosition((Console.WindowWidth - textoUsuario.Length) / 2, Console.CursorTop);
            Console.WriteLine(textoUsuario);
        }
    }
}
