using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Facultad.Dominio.Entidades
{
    public class Salario
    {
        public Salario(double bruto, string codigotransferencia, double descuentos, DateTime fecha) 
        {
            _bruto = bruto;
            _codigotransferencia = codigotransferencia;
            _descuentos = descuentos;
            _fecha = fecha;
        }

        private double _bruto;
        private string _codigotransferencia;
        private double _descuentos;
        private DateTime _fecha;

        public double Bruto
        {
            get
            {
                return _bruto;
            }
            set
            {
                _bruto = value;
            }
        }

        public string Codigotransferencia
        {
            get
            {
                return _codigotransferencia;
            }
            set
            {
                _codigotransferencia = value;
            }
        }

        public double Descuentos
        {
            get
            {
                return _descuentos;
            }
            set
            {
                _descuentos = value;
            }
        }

        public DateTime Fecha
        {
            get
            {
                return _fecha;
            }
            set
            {
                _fecha = value;
            }
        }
    }
}
