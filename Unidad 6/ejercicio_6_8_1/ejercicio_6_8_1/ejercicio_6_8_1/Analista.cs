using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_6_8_1
{
    class Analista : Trabajador
    {
        public string mensaje = "Soy un analista.";
        public Analista()
        {
            Trace.WriteLine("---> Constructor Analista");
        }
        public new string GetIdentidad()
        {
            return base.GetIdentidad() + "\n" + this.mensaje;
        }
    }
}
