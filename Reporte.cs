using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados__repaso1_
{
    internal class Reporte
    {
        string nombre;
        string apellido;
        string sueldomes;
        int mes;
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Sueldomes { get => sueldomes; set => sueldomes = value; }
        public int Mes { get => mes; set => mes = value; }
    }
}
