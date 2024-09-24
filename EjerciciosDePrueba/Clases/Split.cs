using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDePrueba.Clases
{
    internal class Split
    {
        // Declarar los campos y propiedades de la clase

        //Campo: es una variable que se declara dentro de una clase, variables privadas 
        private string color;
        private string marca;
        private int frigorias;
        private bool encendido;

        //Propiedad: es una variable que se declara dentro de una clase, pero que se accede a ella a traves de un metodo, son publicas 

        public int Temperatura;
        public string Modo;


        //Constructor: es un metodo que se ejecuta cuando se crea un objeto de la clase, se encarga de inicializar los campos de la clase
        public Split(string color, string marca, int frigorias)
        {
            this.color = color;
            this.marca = marca;
            this.frigorias = frigorias;

            this.Temperatura = 24;
            this.Modo = "Frio";
            this.encendido = false;
        }
        public void SubirTemperatura()
        {
            if (encendido)
            {
                this.Temperatura++;
            }
            else {
                Console.WriteLine("El split esta apagado");
            }
        }
        public void BajarTemperatura()
        {
            if (encendido)
            {
                this.Temperatura--;
            }
            else
            {
                Console.WriteLine("El split esta apagado");
            }
        }
        public void Encender()
        {
            this.encendido =!this.encendido;
        }
        public void CambiarModo(string modo)
        {
            if (this.encendido)
                this.Modo = modo;
            else
            {
                Console.WriteLine("El split esta apagado");
            }
        }

    }
}
