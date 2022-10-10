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
        private List <Salario> salarios;

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

        public List<Salario> _salarios
        {
            get
            {
                return _salarios;
            }
        }

    }
}
