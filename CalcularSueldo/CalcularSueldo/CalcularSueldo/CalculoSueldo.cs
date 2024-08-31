using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularSueldo
{
    internal class CalculoSueldo
    {
        private int diasTrabajados;

        public int DiasTrabajados { get; set; }

        public int ClacularSueldo(int diastrabajo,int valor)
        {
            return diastrabajo * valor;
        }
    
    }
}
