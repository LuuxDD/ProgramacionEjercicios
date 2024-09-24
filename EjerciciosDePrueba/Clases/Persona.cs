using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDePrueba.Clases
{
    internal class Persona
    {
        private string nombre;
        private string direccion;
        private int añoNac;

        public Persona(string nombre, string direccion, int añoNac)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.añoNac = añoNac;
        }

        public void Decir(string texto)
        {
            Console.WriteLine($"{this.nombre} dice: {texto}");
        }
    }

}
