using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjEjercicioPruebaN
{
    public class Empleado
    {
        string Nombre { get; set; }
        int antiguedad { get; set; }
        int cHrsTrabajadas { get; set; }
        int valorH { get; set; }

        public int CImporte()
        {
            return (valorH * cHrsTrabajadas) + (antiguedad * 30);
        }

        public double Descuentos()
        {
            return CImporte() * 0.13;
        }
    }
}
