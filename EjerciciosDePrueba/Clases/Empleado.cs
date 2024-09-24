using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDePrueba.Clases
{
    abstract class Empleado
    {
        // Declarar los campos y propiedades de la clase
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        //Constructor: es un metodo que se ejecuta cuando se crea un objeto de la clase, se encarga de inicializar los campos de la clase
        public Empleado(string nombre, string apellido, int dni)
        {
            Nombre = nombre;
            Apellido = apellido;
        }
        public virtual string ImprimirDatos()
        {
            return $"Nombre: {Nombre} Apellido: {Apellido}";
        }
    }

}
