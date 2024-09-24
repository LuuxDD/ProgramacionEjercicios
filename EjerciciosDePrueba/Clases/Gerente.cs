using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDePrueba.Clases
{
    internal class Gerente : Empleado
    {
        public Gerente(string nombre, string apellido, int dni) : base(nombre, apellido, dni)
        {
        }

        public override string ImprimirDatos()
        {
            return base.ImprimirDatos() + " Soy un gerente";
        }
    }
}
