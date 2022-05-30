using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_7_2_1_wpf
{
    class Analista : Trabajador
    {
        private string mensaje = "Soy un analista";

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
