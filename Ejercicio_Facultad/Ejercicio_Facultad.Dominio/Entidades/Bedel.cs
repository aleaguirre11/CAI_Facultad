using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Facultad.Dominio.Entidades
{
    public class Bedel : Empleado
    { 
        public Bedel(string apodo, string nombre, string apellido, DateTime fechanacimiento, DateTime fechaingreso, int legajo) : base(fechanacimiento, legajo, nombre, apellido, fechaingreso)
        {
            _apodo = apodo;
        }
        private string _apodo;

        public string Apodo
        {
            get
            {
                return _apodo;
            }
            set
            {
                _apodo = value; 
            }
        }

        public override string GetNombreCompleto()
        {
            return "Apellido: " + Apellido + "Nombre: " + Nombre + "\n";
        }
    }
}
