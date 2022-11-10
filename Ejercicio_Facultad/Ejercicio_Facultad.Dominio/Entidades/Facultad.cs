using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Facultad.Dominio.Entidades
{
    public class Facultad
    {
        public Facultad(string nombre, int cantidadsedes)
        {
            _cantidadsedes = cantidadsedes;
            _nombre = nombre;
            _alumnos = new List<Alumno>();
            _empleados = new List<Empleado>();
        }

        private int _cantidadsedes;
        private string _nombre; 
        private List<Alumno> _alumnos;
        private List<Empleado> _empleados;

        private int CantidadSedes
        {
            get
            {
                return _cantidadsedes;
            }
            set
            {
                _cantidadsedes = value;
            }
        }

        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                _nombre = value;
            }
        }

        public List<Alumno> Alumnos
        {
            get
            {
                return _alumnos;
            }
        }

        public List<Empleado> Empleados
        {
            get
            {
                return _empleados;
            }
        }

        public void AgregarAlumno(Alumno a)
        {
            _alumnos.Add(a);
        }

        public void AgregarEmpleado(Empleado e)
        {
            _empleados.Add(e);  
        }

        public void EliminarAlumno(int codigo)
        {
            foreach (Alumno a in _alumnos)
            {
                if (a.Codigo == codigo)
                {
                    _alumnos.Remove(a);
                }
            }
        }

        public void EliminarEmpleado(int legajo)
        {
            foreach (Empleado e in _empleados)
            {
                if (e.Legajo == legajo)
                {
                    _empleados.Remove(e);
                }
            }
        }

        public void ModificarEmpleado(Empleado e)
        {
            
        }

        public void TraerAlumnos()
        {
            foreach (Alumno alumno in Alumnos)
            {
                Console.WriteLine(alumno.ToString());
            }
        }

        public void TraerEmpleados()
        {
            foreach (Empleado e in Empleados)
            {
                Console.WriteLine(e.ToString());
            }
        }

    }
}
