using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_6_6_4
{
    class Vehiculo
    {
        protected string marca;
        protected string modelo;
        protected int cilindrada;
        protected double potencia;
        protected int cantidadRuedas;

        //Métodos Set y Get de 'marca'.
        public void SetMarca(string marca)
        {
            this.marca = marca;
        }
        public string GetMarca()
        {
            return this.marca;
        }
        //Métodos Set y Get de 'modelo'.
        public void SetModelo(string modelo)
        {
            this.modelo = modelo;
        }
        public string GetModelo()
        {
            return this.modelo;
        }
        //Métodos Set y Get de 'cilindrada'.
        public void SetCilindrada(int cilindrada)
        {
            this.cilindrada = cilindrada;
        }
        public int GetCilindrada()
        {
            return this.cilindrada;
        }
        //Métodos Set y Get de 'potencia'.
        public void SetPotencia(double potencia)
        {
            this.potencia = potencia;
        }
        public double GetPotencia()
        {
            return this.potencia;
        }
        //Métodos Set y Get de 'cantidadRuedas'.
        public void SetRuedas(int cantidadRuedas)
        {
            this.cantidadRuedas = cantidadRuedas;
        }
        public int GetRuedas()
        {
            return this.cantidadRuedas;
        }

    }
}
