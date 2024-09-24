using EjerciciosDePrueba.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDePrueba.Clases
{
    internal class PavaElectrica
    {
        //Declarar los campos 
        string marca;
        string material;
        int capacidad;

        //Propiedades
        public int Temperatura { get; set; }
        public bool Encendida { get; set; }

        public ModoEnums Modo;

        //Constructor
        public PavaElectrica(string marca, string material, int capacidad)
        {
            this.marca = marca;
            this.material = material;
            this.capacidad = capacidad;

            this.Temperatura = 20;
            this.Encendida = false;
            this.Modo = ModoEnums.TemperaturaMate;
        }

        public void Encender()
        {
            this.Encendida = !this.Encendida;
        }

        public void CambiarModo(ModoEnums modo)
        {
            this.Modo = modo;
            if (modo == ModoEnums.TemperaturaMate)
            {
                this.Temperatura = 70;
            }
            else if (modo == ModoEnums.TemperaturaTe)
            {
                this.Temperatura = 85;
            }
            else if (modo == ModoEnums.TemperaturaCafe)
            {
                this.Temperatura = 90;
            }


        }
    }
}
