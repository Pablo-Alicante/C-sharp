using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_6_8_1
{
    class Ingeniero : Trabajador
    {
        public string mensaje = "Soy un ingeniero.";
        public Ingeniero() : base()
        {
            Trace.WriteLine("---> Constructor Ingeniero");
        }
        public new string GetIdentidad()
        {
            return base.GetIdentidad() + "\n" + this.mensaje;
        }
    }
}
