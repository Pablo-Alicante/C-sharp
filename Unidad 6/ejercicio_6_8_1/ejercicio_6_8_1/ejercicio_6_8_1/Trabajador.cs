using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_6_8_1
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
