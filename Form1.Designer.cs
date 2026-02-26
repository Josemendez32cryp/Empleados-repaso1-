using System;
using System.Windows.Forms;

namespace Empleados__repaso1_
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Empleados = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonempleado = new System.Windows.Forms.Button();
            this.numericsueldo = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textboxapellido = new System.Windows.Forms.TextBox();
            this.textboxnombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Labelempleado = new System.Windows.Forms.Label();
            this.numericempleado = new System.Windows.Forms.NumericUpDown();
            this.Asistencia = new System.Windows.Forms.TabPage();
            this.dataGridAsistencia = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mesasistencia = new System.Windows.Forms.NumericUpDown();
            this.horastrabajadasasist = new System.Windows.Forms.NumericUpDown();
            this.numempleadoasist = new System.Windows.Forms.NumericUpDown();
            this.Reporte = new System.Windows.Forms.TabPage();
            this.reportebutton = new System.Windows.Forms.Button();
            this.datagridreportes = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.Empleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericsueldo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericempleado)).BeginInit();
            this.Asistencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAsistencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesasistencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horastrabajadasasist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numempleadoasist)).BeginInit();
            this.Reporte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridreportes)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Empleados);
            this.tabControl1.Controls.Add(this.Asistencia);
            this.tabControl1.Controls.Add(this.Reporte);
            this.tabControl1.Location = new System.Drawing.Point(1, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1051, 546);
            this.tabControl1.TabIndex = 0;
            // 
            // Empleados
            // 
            this.Empleados.Controls.Add(this.dataGridView1);
            this.Empleados.Controls.Add(this.buttonempleado);
            this.Empleados.Controls.Add(this.numericsueldo);
            this.Empleados.Controls.Add(this.label3);
            this.Empleados.Controls.Add(this.label2);
            this.Empleados.Controls.Add(this.textboxapellido);
            this.Empleados.Controls.Add(this.textboxnombre);
            this.Empleados.Controls.Add(this.label1);
            this.Empleados.Controls.Add(this.Labelempleado);
            this.Empleados.Controls.Add(this.numericempleado);
            this.Empleados.Location = new System.Drawing.Point(4, 25);
            this.Empleados.Name = "Empleados";
            this.Empleados.Padding = new System.Windows.Forms.Padding(3);
            this.Empleados.Size = new System.Drawing.Size(1043, 517);
            this.Empleados.TabIndex = 0;
            this.Empleados.Text = "Empleados";
            this.Empleados.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(514, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(496, 277);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonempleado
            // 
            this.buttonempleado.Location = new System.Drawing.Point(184, 329);
            this.buttonempleado.Name = "buttonempleado";
            this.buttonempleado.Size = new System.Drawing.Size(249, 75);
            this.buttonempleado.TabIndex = 9;
            this.buttonempleado.Text = "ingresar empleado";
            this.buttonempleado.UseVisualStyleBackColor = true;
            this.buttonempleado.Click += new System.EventHandler(this.buttonempleado_Click);
            // 
            // numericsueldo
            // 
            this.numericsueldo.DecimalPlaces = 2;
            this.numericsueldo.Location = new System.Drawing.Point(209, 234);
            this.numericsueldo.Name = "numericsueldo";
            this.numericsueldo.Size = new System.Drawing.Size(233, 22);
            this.numericsueldo.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sueldo x Hora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Apellido de empleado";
            // 
            // textboxapellido
            // 
            this.textboxapellido.Location = new System.Drawing.Point(209, 161);
            this.textboxapellido.Name = "textboxapellido";
            this.textboxapellido.Size = new System.Drawing.Size(224, 22);
            this.textboxapellido.TabIndex = 4;
            // 
            // textboxnombre
            // 
            this.textboxnombre.Location = new System.Drawing.Point(209, 101);
            this.textboxnombre.Name = "textboxnombre";
            this.textboxnombre.Size = new System.Drawing.Size(224, 22);
            this.textboxnombre.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "nombre de empleado";
            // 
            // Labelempleado
            // 
            this.Labelempleado.AutoSize = true;
            this.Labelempleado.Location = new System.Drawing.Point(56, 61);
            this.Labelempleado.Name = "Labelempleado";
            this.Labelempleado.Size = new System.Drawing.Size(139, 16);
            this.Labelempleado.TabIndex = 1;
            this.Labelempleado.Text = "Numero de empleado";
            // 
            // numericempleado
            // 
            this.numericempleado.Location = new System.Drawing.Point(209, 61);
            this.numericempleado.Name = "numericempleado";
            this.numericempleado.Size = new System.Drawing.Size(224, 22);
            this.numericempleado.TabIndex = 0;
            // 
            // Asistencia
            // 
            this.Asistencia.Controls.Add(this.dataGridAsistencia);
            this.Asistencia.Controls.Add(this.button1);
            this.Asistencia.Controls.Add(this.label6);
            this.Asistencia.Controls.Add(this.label5);
            this.Asistencia.Controls.Add(this.label4);
            this.Asistencia.Controls.Add(this.mesasistencia);
            this.Asistencia.Controls.Add(this.horastrabajadasasist);
            this.Asistencia.Controls.Add(this.numempleadoasist);
            this.Asistencia.Location = new System.Drawing.Point(4, 25);
            this.Asistencia.Name = "Asistencia";
            this.Asistencia.Padding = new System.Windows.Forms.Padding(3);
            this.Asistencia.Size = new System.Drawing.Size(1043, 517);
            this.Asistencia.TabIndex = 1;
            this.Asistencia.Text = "Asistencia";
            this.Asistencia.UseVisualStyleBackColor = true;
            // 
            // dataGridAsistencia
            // 
            this.dataGridAsistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAsistencia.Location = new System.Drawing.Point(484, 18);
            this.dataGridAsistencia.Name = "dataGridAsistencia";
            this.dataGridAsistencia.RowHeadersWidth = 51;
            this.dataGridAsistencia.RowTemplate.Height = 24;
            this.dataGridAsistencia.Size = new System.Drawing.Size(539, 314);
            this.dataGridAsistencia.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 77);
            this.button1.TabIndex = 9;
            this.button1.Text = "Agregar asistencia";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Mes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "horas trabajadaas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "numero de empleado";
            // 
            // mesasistencia
            // 
            this.mesasistencia.Location = new System.Drawing.Point(189, 197);
            this.mesasistencia.Name = "mesasistencia";
            this.mesasistencia.Size = new System.Drawing.Size(235, 22);
            this.mesasistencia.TabIndex = 5;
            // 
            // horastrabajadasasist
            // 
            this.horastrabajadasasist.Location = new System.Drawing.Point(184, 125);
            this.horastrabajadasasist.Name = "horastrabajadasasist";
            this.horastrabajadasasist.Size = new System.Drawing.Size(240, 22);
            this.horastrabajadasasist.TabIndex = 4;
            // 
            // numempleadoasist
            // 
            this.numempleadoasist.Location = new System.Drawing.Point(183, 35);
            this.numempleadoasist.Name = "numempleadoasist";
            this.numempleadoasist.Size = new System.Drawing.Size(241, 22);
            this.numempleadoasist.TabIndex = 3;
            // 
            // Reporte
            // 
            this.Reporte.Controls.Add(this.reportebutton);
            this.Reporte.Controls.Add(this.datagridreportes);
            this.Reporte.Location = new System.Drawing.Point(4, 25);
            this.Reporte.Name = "Reporte";
            this.Reporte.Padding = new System.Windows.Forms.Padding(3);
            this.Reporte.Size = new System.Drawing.Size(1043, 517);
            this.Reporte.TabIndex = 2;
            this.Reporte.Text = "Reporte";
            this.Reporte.UseVisualStyleBackColor = true;
            // 
            // reportebutton
            // 
            this.reportebutton.Location = new System.Drawing.Point(441, 445);
            this.reportebutton.Name = "reportebutton";
            this.reportebutton.Size = new System.Drawing.Size(204, 56);
            this.reportebutton.TabIndex = 1;
            this.reportebutton.Text = "GENERAR REPORTE";
            this.reportebutton.UseVisualStyleBackColor = true;
            this.reportebutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // datagridreportes
            // 
            this.datagridreportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridreportes.Location = new System.Drawing.Point(44, 7);
            this.datagridreportes.Name = "datagridreportes";
            this.datagridreportes.RowHeadersWidth = 51;
            this.datagridreportes.RowTemplate.Height = 24;
            this.datagridreportes.Size = new System.Drawing.Size(993, 432);
            this.datagridreportes.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 546);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.Empleados.ResumeLayout(false);
            this.Empleados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericsueldo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericempleado)).EndInit();
            this.Asistencia.ResumeLayout(false);
            this.Asistencia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAsistencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesasistencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horastrabajadasasist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numempleadoasist)).EndInit();
            this.Reporte.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridreportes)).EndInit();
            this.ResumeLayout(false);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Empleados;
        private System.Windows.Forms.TextBox textboxapellido;
        private System.Windows.Forms.TextBox textboxnombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Labelempleado;
        private System.Windows.Forms.NumericUpDown numericempleado;
        private System.Windows.Forms.TabPage Asistencia;
        private System.Windows.Forms.TabPage Reporte;
        private System.Windows.Forms.Button buttonempleado;
        private System.Windows.Forms.NumericUpDown numericsueldo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Button reportebutton;
        private DataGridView datagridreportes;
        private NumericUpDown numempleadoasist;
        private Label label5;
        private Label label4;
        private NumericUpDown mesasistencia;
        private NumericUpDown horastrabajadasasist;
        private Button button1;
        private Label label6;
        private DataGridView dataGridAsistencia;
    }
}

