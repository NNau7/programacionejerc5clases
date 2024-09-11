using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programacionejerc5clases
{
    internal class Docente : Empleado,IRangoEdades
    {
        public Docente()
        {

        }

        public Docente(string nombre, int edad, string puesto) : base(nombre, edad, puesto)
        {

        }

        public string RangoEdades()
        {
            if (Edad >= 18 && Edad < 30)
            {
                return "joven";
            }
            else if (Edad >= 30 && Edad < 40)
            {
                return "adulto-joven";
            }
            else if (Edad >= 40 && Edad < 60)
            {
                return "adulto";
            }
            else if (Edad >= 60 && Edad <= 80)
            {
                return "adulto-mayor";
            }
            else
            {
                return "La edad se encuentra fuera del rango de edades de doentes";
            }
        }
    }
}
