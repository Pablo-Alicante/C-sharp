using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_6_5_2
{
    class PersonaInglesa : Persona
    {
        public string TomarTe()
        {
            return "Estoy tomando té";
        }

        new public string Saludar()
        {
            return "Hi, I am " + this.nombre;
        }
    }
}
