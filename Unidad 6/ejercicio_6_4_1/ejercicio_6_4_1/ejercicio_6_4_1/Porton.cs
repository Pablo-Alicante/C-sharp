using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_6_4_1
{
    class Porton : Puerta
    {
        public bool bloqueada; // bloqueada o desbloqueada.

        //Métodos Set y Get de 'bloqueada'.
        public void SetBloqueada(bool bloqueada)
        {
            this.bloqueada = bloqueada;
        }
        public string GetBloqueada()
        {
            return bloqueada == true ? "El portón está desbloqueado" : "El portón está bloqueado";
        }
    }
}
