using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularSueldo
{
    internal class Empleados
    {
        private string nombre;
        private int legajo;
        private decimal sueldoDiario;

        public string Nombre { get {  return nombre; } set {  nombre = value; } }
        public int Legajo { get { return legajo; } set { legajo = value; } }
        public decimal SueldoDiario { get {  return sueldoDiario; } set { sueldoDiario = value; } }

    }
}
