using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados__repaso1_
{
    internal class empleado
    {
        String nombre;
        int noempleado;
        String apellido;
        decimal sueldoxhora;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Numeroempleado { get => noempleado; set => noempleado = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public decimal Sueldoxhora { get => sueldoxhora; set => sueldoxhora = value; }
    }
}
