using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empleados__repaso1_
{ 
    public partial class Form1 : Form
    {
        List<empleado> empleadoslist = new List<empleado>();
        public Form1()
        {
            InitializeComponent();
            LeerEmpleado();
            mostrar();
        }
        private void LeerEmpleado()
        {
            
            string fileName = "Dataempleados.txt";

            
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            
            while (reader.Peek() > -1)
            
            {
                empleado leerempleado = new empleado();
                leerempleado.Numeroempleado=Convert.ToInt16(reader.ReadLine());
                leerempleado.Nombre=reader.ReadLine();
                leerempleado.Apellido=reader.ReadLine();
                leerempleado.Sueldoxhora=Convert.ToDecimal(reader.ReadLine());

                empleadoslist.Add(leerempleado);
            }
            
            reader.Close();
            mostrar();
        }
        private void mostrar()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = empleadoslist;
        }
        private void GuardarEmpleado()
        {
            FileStream stream = new FileStream("Dataempleados.txt", FileMode.Create, FileAccess.Write);
            
            StreamWriter writer = new StreamWriter(stream);

            foreach (var item in empleadoslist)
            {
                writer.WriteLine(item.Numeroempleado);
                writer.WriteLine(item.Nombre);
                writer.WriteLine(item.Apellido);
                writer.WriteLine(item.Sueldoxhora);
            }
            
            writer.Close();
            mostrar();

        }

        private void buttonempleado_Click(object sender, EventArgs e)
        {
            empleado nuevoempleado = new empleado();
            nuevoempleado.Numeroempleado = Convert.ToInt16(numericempleado.Value);
            nuevoempleado.Nombre=textboxnombre.Text;
            nuevoempleado.Apellido=textboxapellido.Text;
            nuevoempleado.Sueldoxhora=numericsueldo.Value;

            empleadoslist.Add(nuevoempleado);
            GuardarEmpleado();
            mostrar();

        }
    }
}
