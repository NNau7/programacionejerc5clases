using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programacionejerc5clases
{
    internal class NoDocente : Empleado, IRangoEdades
    {
        public NoDocente()
        {

        }

        public NoDocente(string nombre, int edad, string puesto) : base(nombre, edad, puesto)
        {

        }

        public string RangoEdades()
        {
            if (Edad >= 15 && Edad < 18)
            {
                return "menor de edad";
            }
            else if (Edad >= 18 && Edad < 30)
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
            else
            {
                return "La edad se encuentra fuera del rango de edades de no docentes";
            }
        }
    }
}
