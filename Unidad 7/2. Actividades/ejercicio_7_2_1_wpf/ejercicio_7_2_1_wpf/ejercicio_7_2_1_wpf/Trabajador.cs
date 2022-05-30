using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_7_2_1_wpf
{
    class Trabajador
    {
        public string mensaje = "Soy un trabajador.";

        public Trabajador()
        {
            Trace.WriteLine("---> Constructor trabajador");
        }
        public string GetIdentidad()
        {
            return this.mensaje;
        }
    }
}
