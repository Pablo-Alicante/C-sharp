using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_6_4_1
{
    class Puerta
    {
        public int ancho; // Ancho en centimetros
        public int alto; // Alto en centimetros
        public int color; // Color en formato RGB
        public bool abierta; // Abierta o cerrada

        //Métodos Set y Get de 'ancho'.
        public void SetAncho(int ancho)
        {
            this.ancho = ancho;
        }
        public int GetAncho()
        {
            return this.ancho;
        }

        //Métodos Set y Get de 'alto'.
        public void SetAlto(int alto)
        {
            this.alto = alto;
        }
        public int GetAlto()
        {
            return this.alto;
        }

        //Métodos Set y Get de 'color'.
        public void SetColor(int color)
        {
            this.color = color;
        }
        public int GetColor()
        {
            return this.color;
        }

        //Métodos Set y Get de 'abierta'.
        public void SetAbierta(bool abierta)
        {
            this.abierta = abierta;
        }
        public string GetAbierta()
        {
            return abierta == true ? "La puerta está abierta" : "La puerta está cerrada";
        }
    }
}
