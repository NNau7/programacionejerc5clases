using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programacionejerc5clases
{
    internal class Cursando : Estudiante, IRangoEdades
    {
        private int año;
        private string materia;
        private float nota;

        public int Año { get => año; set => año = value; }
        public string Materia { get => materia; set => materia = value; }
        public float Nota { get => nota; set => nota = value; }

        public Cursando()
        {

        }

        public Cursando(string name, int edad, string carrera, string estado, int año, string materia, float nota) : base(name, edad, carrera, estado)
        {
            this.Materia = materia;
            this.Nota = nota;
            this.Año = año;
        }

        public override void Condicion()
        {
            Console.WriteLine($"Se encuentra en {Año} año");
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
            else if (Edad >= 60 && Edad <= 80)
            {
                return "adulto-mayor";
            }
            else
            {
                return "La edad se encuentra fuera del rango de edades de alumnos cursando";
            }
        }
    }
}
