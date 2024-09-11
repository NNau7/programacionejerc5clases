using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programacionejerc5clases
{
    internal sealed class ExAlumno:Estudiante
    {
        private float promedio;

        public float Promedio { get => promedio; set => promedio = value; }

        public ExAlumno()
        {

        }

        public ExAlumno(string name, int edad, string carrera, string estado,float promedio) : base(name,edad,carrera,estado)
        {
            this.Promedio = promedio;
        }

        public override void Condicion()
        {
            Console.WriteLine($"Exalumno  con promedio de {Promedio}");
        }
    }
}
