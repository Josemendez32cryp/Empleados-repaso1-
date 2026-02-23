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
            this.Asistencia = new System.Windows.Forms.TabPage();
            this.Reporte = new System.Windows.Forms.TabPage();
            this.numericempleado = new System.Windows.Forms.NumericUpDown();
            this.Labelempleado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textboxnombre = new System.Windows.Forms.TextBox();
            this.textboxapellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericsueldo = new System.Windows.Forms.NumericUpDown();
            this.buttonempleado = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.Empleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericempleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericsueldo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(798, 416);
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
            this.Empleados.Size = new System.Drawing.Size(790, 387);
            this.Empleados.TabIndex = 0;
            this.Empleados.Text = "Empleados";
            this.Empleados.UseVisualStyleBackColor = true;
            // 
            // Asistencia
            // 
            this.Asistencia.Location = new System.Drawing.Point(4, 25);
            this.Asistencia.Name = "Asistencia";
            this.Asistencia.Padding = new System.Windows.Forms.Padding(3);
            this.Asistencia.Size = new System.Drawing.Size(790, 387);
            this.Asistencia.TabIndex = 1;
            this.Asistencia.Text = "Asistencia";
            this.Asistencia.UseVisualStyleBackColor = true;
            // 
            // Reporte
            // 
            this.Reporte.Location = new System.Drawing.Point(4, 25);
            this.Reporte.Name = "Reporte";
            this.Reporte.Padding = new System.Windows.Forms.Padding(3);
            this.Reporte.Size = new System.Drawing.Size(790, 387);
            this.Reporte.TabIndex = 2;
            this.Reporte.Text = "Reporte";
            this.Reporte.UseVisualStyleBackColor = true;
            // 
            // numericempleado
            // 
            this.numericempleado.Location = new System.Drawing.Point(209, 61);
            this.numericempleado.Name = "numericempleado";
            this.numericempleado.Size = new System.Drawing.Size(224, 22);
            this.numericempleado.TabIndex = 0;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "nombre de empleado";
            // 
            // textboxnombre
            // 
            this.textboxnombre.Location = new System.Drawing.Point(209, 101);
            this.textboxnombre.Name = "textboxnombre";
            this.textboxnombre.Size = new System.Drawing.Size(224, 22);
            this.textboxnombre.TabIndex = 3;
            // 
            // textboxapellido
            // 
            this.textboxapellido.Location = new System.Drawing.Point(209, 161);
            this.textboxapellido.Name = "textboxapellido";
            this.textboxapellido.Size = new System.Drawing.Size(224, 22);
            this.textboxapellido.TabIndex = 4;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sueldo x Hora";
            // 
            // numericsueldo
            // 
            this.numericsueldo.DecimalPlaces = 2;
            this.numericsueldo.Location = new System.Drawing.Point(209, 234);
            this.numericsueldo.Name = "numericsueldo";
            this.numericsueldo.Size = new System.Drawing.Size(233, 22);
            this.numericsueldo.TabIndex = 8;
            // 
            // buttonempleado
            // 
            this.buttonempleado.Location = new System.Drawing.Point(278, 282);
            this.buttonempleado.Name = "buttonempleado";
            this.buttonempleado.Size = new System.Drawing.Size(249, 75);
            this.buttonempleado.TabIndex = 9;
            this.buttonempleado.Text = "ingresar empleado";
            this.buttonempleado.UseVisualStyleBackColor = true;
            this.buttonempleado.Click += new System.EventHandler(this.buttonempleado_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(514, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.Empleados.ResumeLayout(false);
            this.Empleados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericempleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericsueldo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
    }
}

