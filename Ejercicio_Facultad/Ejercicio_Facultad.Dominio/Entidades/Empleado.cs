using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Facultad.Dominio.Entidades
{
    public class Empleado : Persona
    {
        public Empleado(DateTime fechaingreso, int legajo, string nombre, string apellido, DateTime fechanacimiento) : base(nombre, apellido, fechanacimiento)
        {
            _fechaingreso = fechaingreso;
            _legajo = legajo;
            _salarios = new List<Salario>();
        }
        private DateTime _fechaingreso; 
        private int _legajo;    
        private List <Salario> _salarios;

        public DateTime Fechaingreso
        {
            get
            {
                return _fechaingreso;
            }
            set
            {
                _fechaingreso = value;
            }
        }

        public int Legajo
        {
            get
            {
                return _legajo;
            }
            set
            {
                _legajo = value;
            }
        }

        public List<Salario> Salarios
        {
            get
            {
                return _salarios;
            }
            set
            {
                _salarios = value;
            }
        }

        public void AgregarSalario(Salario s)
        {
            _salarios.Add(s);
        }

        public override string GetNombreCompleto()
        {
            return "Apellido: " + Apellido + "Nombre: " + Nombre + "\n";
        }

        public override string ToString()
        {
            return Nombre + " - " + Apellido;
        }


    }
}
