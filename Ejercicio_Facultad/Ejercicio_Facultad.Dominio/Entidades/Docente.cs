using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Facultad.Dominio.Entidades
{
    public class Docente : Empleado
    {
        public Docente(string nombre, string apellido, DateTime fechanacimiento, DateTime fechaingreso, int legajo) : base(fechanacimiento, legajo, nombre, apellido, fechaingreso)
        {

        }
    }
}
