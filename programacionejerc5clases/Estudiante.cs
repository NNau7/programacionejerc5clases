using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace programacionejerc5clases
{
    internal class Estudiante:Persona
    {
        private string carrera;
        private string estado;

        public string Carrera { get => carrera; set => carrera = value; }
        public string Estado { get => estado; set => estado = value; }

        public Estudiante()
        {

        }

        public Estudiante(string name, int edad,string carrera,string estado) : base(edad, name)
        {
            this.Carrera = carrera;
            this.Estado = estado;
        }


        public override void Infopersona()
        {
            Console.WriteLine($"{Name} es un alumno de la Universidad que se encuentra en la carrera {Carrera} en estado: {Estado}");
        }
    }
}
