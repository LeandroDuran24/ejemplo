﻿namespace Registros.UI.Consultas
{
    partial class ConsultaPelicula
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.desdedateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.hastadateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hasta";
            // 
            // desdedateTimePicker1
            // 
            this.desdedateTimePicker1.CustomFormat = "yyy/MM/dd";
            this.desdedateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.desdedateTimePicker1.Location = new System.Drawing.Point(94, 12);
            this.desdedateTimePicker1.Name = "desdedateTimePicker1";
            this.desdedateTimePicker1.Size = new System.Drawing.Size(102, 20);
            this.desdedateTimePicker1.TabIndex = 2;
            // 
            // hastadateTimePicker2
            // 
            this.hastadateTimePicker2.CustomFormat = "yyy/MM/dd";
            this.hastadateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.hastadateTimePicker2.Location = new System.Drawing.Point(252, 11);
            this.hastadateTimePicker2.Name = "hastadateTimePicker2";
            this.hastadateTimePicker2.Size = new System.Drawing.Size(90, 20);
            this.hastadateTimePicker2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(171, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Filtrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(307, 183);
            this.dataGridView1.TabIndex = 5;
            // 
            // ConsultaPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 261);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.hastadateTimePicker2);
            this.Controls.Add(this.desdedateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ConsultaPelicula";
            this.Text = "ConsultaPelicula";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker desdedateTimePicker1;
        private System.Windows.Forms.DateTimePicker hastadateTimePicker2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}