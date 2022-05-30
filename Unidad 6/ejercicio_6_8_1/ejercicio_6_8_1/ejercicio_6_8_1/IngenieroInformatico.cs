using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_6_8_1
{
    class IngenieroInformatico : Ingeniero
    {
        public string mensaje = "Soy un ingeniero informático";
        public IngenieroInformatico() : base()
        {
            Trace.WriteLine("---> Constructor IngenieroInformatico");
        }
        public new string GetIdentidad()
        {
            return base.GetIdentidad() + "\n" + this.mensaje;
        }

    }
}
