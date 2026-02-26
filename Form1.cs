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
        List<Asistencia> asistenciaslist = new List<Asistencia>();
        List<Reporte> reporteslist = new List<Reporte>();
        public Form1()
        {
            InitializeComponent();
            LeerEmpleado();
            LeerAsistencia();
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
        private void LeerAsistencia()
        {
            FileStream stream = new FileStream("Asistenciaempleados.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while ( reader.Peek() > -1)
            {
                Asistencia lecturaempleado = new Asistencia();
                lecturaempleado.NoEmpleado = Convert.ToInt16(reader.ReadLine());
                lecturaempleado.Horastrabajadas = Convert.ToInt16(reader.ReadLine());
                lecturaempleado.Mes = Convert.ToInt16(reader.ReadLine());
                asistenciaslist.Add(lecturaempleado);
            }
            reader.Close();
            mostrarasistencia();
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

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in empleadoslist)
            {
                foreach (var asis in asistenciaslist)
                {
                    if (item.Numeroempleado == asis.NoEmpleado)
                    {
                        Reporte reporte = new Reporte();
                        reporte.Nombre = item.Nombre;
                        reporte.Sueldomes = (item.Sueldoxhora * asis.Horastrabajadas).ToString();
                        reporte.Mes = asis.Mes;
                        reporte.Apellido = item.Apellido;

                        reporteslist.Add(reporte);
                    }
                }

            }
            mostrarreporte();
            
        }
        private void mostrarreporte()
        {
            datagridreportes.DataSource = null;
            datagridreportes.DataSource = reporteslist;
        }
        private void mostrarasistencia()
        {
            dataGridAsistencia.DataSource = null;
            dataGridAsistencia.DataSource = asistenciaslist;
        }
        private void GuardarAsistencia()
        {
            FileStream stream = new FileStream("Asistenciaempleados.txt", FileMode.Create, FileAccess.Write);

            StreamWriter writer = new StreamWriter(stream);

            foreach (var item in asistenciaslist)
            {
                writer.WriteLine(item.NoEmpleado);
                writer.WriteLine(item.Horastrabajadas);
                writer.WriteLine(item.Mes);
                
            }

            writer.Close();
            mostrarasistencia();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Asistencia nuevaasistencia = new Asistencia();
            nuevaasistencia.NoEmpleado = Convert.ToInt16(numempleadoasist.Value);
            nuevaasistencia.Horastrabajadas = Convert.ToInt16(horastrabajadasasist.Value);
            nuevaasistencia.Mes = Convert.ToInt16(mesasistencia.Value);
            asistenciaslist.Add(nuevaasistencia);
            GuardarAsistencia();
            mostrarasistencia();

        }
    }
}
