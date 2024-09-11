using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace programacionejerc5clases
{
    public abstract class Persona
    {
        private int edad;
        private string name;

        public int Edad { get => edad; set => edad = value; }
        public string Name { get => name; set => name = value; }

        public Persona(int edad, string name)
        {
            this.edad = edad;
            this.name = name;
        }

        public Persona()
        {

        }

        public abstract void Infopersona();

        public virtual void Condicion()
        {
            Console.WriteLine($"{Name} es una Persona");
        }
        
    }
}
