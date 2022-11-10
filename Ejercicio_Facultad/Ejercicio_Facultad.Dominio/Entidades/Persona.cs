using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Facultad.Dominio.Entidades
{
    public class Persona
    {
        public Persona(string apellido, string nombre, DateTime fechanacimiento)
        {
            _apellido = apellido;
            _nombre = nombre;
            _fechanacimiento = fechanacimiento;
        }

        protected string _apellido;
        protected string _nombre;
        protected DateTime _fechanacimiento;

        public string Apellido
        {
            get
            {
                return _apellido;
            }
            set
            {
                _apellido = value;
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

        public DateTime Fechanacimiento
        {
            get
            {
                return _fechanacimiento;
            }
            set
            {
                _fechanacimiento = value;
            }
        }

        public virtual string GetNombreCompleto()
        {
            return "Apellido: " + Apellido + "Nombre: " +  Nombre + "\n";
        }


    }
}
