using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_7_2_1_wpf
{
    class Programador : Trabajador
    {
        public string mensaje = "Soy un programador.";

        public Programador()
        {
            Trace.WriteLine("---> Constructor Programador");
        }
        public new string GetIdentidad()
        {
            return base.GetIdentidad() + "\n" + this.mensaje;
        }
    }
}
