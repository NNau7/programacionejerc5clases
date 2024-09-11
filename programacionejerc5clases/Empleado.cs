using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programacionejerc5clases
{
    internal class Empleado : Persona
    {
        private string puesto;
        private int antiguedad;
        private float salario;

        public string Puesto { get => puesto; set => puesto = value; }
        public int Antiguedad { get => antiguedad; set => antiguedad = value; }
        public float Salario { get => salario; set => salario = value; }

        public Empleado() 
        {

        }

        public Empleado(string name,int edad, string puesto) : base(edad,name)
        {
            this.Puesto = puesto;
        }

        public override void Infopersona()
        {
            Console.WriteLine($"{Name} es un empleado de la Universidad que se encuentra en el puesto: {Puesto}");
        }
    }
}
