using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programacionejerc5clases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Cursando> listaAlumnos;
            List<Docente> listaDocentes;
            List<NoDocente> listaNoDocentes;
            listaAlumnos = LlenaInformacionAlumno();
            listaDocentes = LlenaInformacionDocente();
            listaNoDocentes = LlenaInformacionNoDocente();

            Console.WriteLine("Menú de opciones:");
            Console.WriteLine("1-Mostrar Alumnos menores de edad");
            Console.WriteLine("2-Mostrar Docentes Jovenes");
            Console.WriteLine("3-Mostrar No Docentes Adultos");
            Console.WriteLine("Elija una opción");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    List<Cursando> resultado = listaAlumnos.FindAll(a => a.RangoEdades() == "menor de edad");
                    if (resultado.Count > 0) resultado.ForEach(x => x.Infopersona());
                    else Console.WriteLine("No se encontraron alumnos menores de edad");
                    break;
                case 2:
                    List<Docente> resultdocente = listaDocentes.FindAll(d => d.RangoEdades() == "joven");
                    if (resultdocente.Count > 0) resultdocente.ForEach(x => x.Infopersona());
                    else Console.WriteLine("No se encontraron docentes jovenes");
                    break;
                case 3:
                    List<NoDocente> resultnodocente = listaNoDocentes.FindAll(n => n.RangoEdades() == "adulto");
                    if (resultnodocente.Count > 0) resultnodocente.ForEach(x => x.Infopersona());
                    else Console.WriteLine("Nose encontro No docente adulto");
                    break;
                default:
                    Console.WriteLine("La opcion seleccionada no esta dentro de las opciones");
                    break;
            }

            Console.ReadKey();

        }

    

        static List<Cursando> LlenaInformacionAlumno()
        {
            List<Cursando> listCursando = new List<Cursando>();
            string op;

            do
            {

                Console.WriteLine("Lista Alumnos");
                Console.WriteLine("Ingrese el nombre del alumno: ");
                string nombre = Console.ReadLine();
                Console.WriteLine("Ingrese la edad del alumno: ");
                int edad = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la carrera: ");
                string carrera = Console.ReadLine();
                Console.WriteLine("Ingrese estado(Cursando/Exalumno): ");
                string estado = Console.ReadLine();
                Console.WriteLine("Ingrese que año esta cursando de la carrera: ");
                int anio = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la materia: ");
                string materia = Console.ReadLine();
                Console.WriteLine("Ingrese la nota de la materia: ");
                int nota = int.Parse(Console.ReadLine());
                listCursando.Add(new Cursando() { Name = nombre, Edad = edad, Carrera = carrera, Estado = estado, Año = anio, Materia = materia, Nota = nota });

                Console.WriteLine("Seguimos introduciendo datos (s/n): ");
                op = Console.ReadLine();

            }
            while (op != "n");

            return listCursando;
        }
        static List<Docente> LlenaInformacionDocente()
        {
            List<Docente> listDocente = new List<Docente>();
            string op;

            do
            {

                Console.WriteLine("Lista Docentes");
                Console.WriteLine("Ingrese el nombre del docente: ");
                string nombre = Console.ReadLine();
                Console.WriteLine("Ingrese la edad del docente: ");
                int edad = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese puesto: ");
                string puesto = Console.ReadLine();
                listDocente.Add(new Docente() { Name = nombre, Edad = edad, Puesto = puesto });

                Console.WriteLine("Seguimos introduciendo datos (s/n): ");
                op = Console.ReadLine();

            }
            while (op != "n");
            return listDocente;

        }

        static List<NoDocente> LlenaInformacionNoDocente()
        {
            List<NoDocente> listNoDocente = new List<NoDocente>();
            string op;

            do
            {

                Console.WriteLine("Lista No Docente");
                Console.WriteLine("Ingrese nombre: ");
                string nombre = Console.ReadLine();
                Console.WriteLine("Ingrese la edad: ");
                int edad = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese puesto: ");
                string puesto = Console.ReadLine();
                listNoDocente.Add(new NoDocente() { Name = nombre, Edad = edad, Puesto = puesto });

                Console.WriteLine("Seguimos introduciendo datos (s/n): ");
                op = Console.ReadLine();

            }
            while (op != "n");
            return listNoDocente;

        }
    }
}
