using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Facultad.Dominio.Entidades
{
    public class Alumno : Persona
    {
        public Alumno(int codigo, string nombre, string apellido, DateTime fechanacimiento) : base(nombre, apellido, fechanacimiento)
        {
            _codigo = codigo;
        }
        private int _codigo;
        
        public int Codigo
        {
            get
            {
                return _codigo;
            }
            set
            {
                _codigo = value;
            }
        }

        public override string ToString()
        {
            return Nombre + " - " + Apellido;
        }

        public override string GetNombreCompleto()
        {
            return "Apellido: " + Apellido + "Nombre: " + Nombre + "\n";
        }

    }
}
