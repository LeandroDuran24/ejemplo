namespace Registros.UI.Registros
{
    partial class PeliculaForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label peliculaIdLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label fechaExtrenoLabel;
            this.peliculaIdTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.fechaExtrenoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.buscar = new System.Windows.Forms.Button();
            this.Nuevo = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            peliculaIdLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            fechaExtrenoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // peliculaIdLabel
            // 
            peliculaIdLabel.AutoSize = true;
            peliculaIdLabel.Location = new System.Drawing.Point(161, 110);
            peliculaIdLabel.Name = "peliculaIdLabel";
            peliculaIdLabel.Size = new System.Drawing.Size(59, 13);
            peliculaIdLabel.TabIndex = 1;
            peliculaIdLabel.Text = "Pelicula Id:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(161, 136);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 3;
            nombreLabel.Text = "Nombre:";
            // 
            // fechaExtrenoLabel
            // 
            fechaExtrenoLabel.AutoSize = true;
            fechaExtrenoLabel.Location = new System.Drawing.Point(161, 163);
            fechaExtrenoLabel.Name = "fechaExtrenoLabel";
            fechaExtrenoLabel.Size = new System.Drawing.Size(79, 13);
            fechaExtrenoLabel.TabIndex = 5;
            fechaExtrenoLabel.Text = "Fecha Extreno:";
            // 
            // peliculaIdTextBox
            // 
            this.peliculaIdTextBox.Location = new System.Drawing.Point(246, 107);
            this.peliculaIdTextBox.Name = "peliculaIdTextBox";
            this.peliculaIdTextBox.Size = new System.Drawing.Size(200, 20);
            this.peliculaIdTextBox.TabIndex = 2;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(246, 133);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombreTextBox.TabIndex = 4;
            // 
            // fechaExtrenoDateTimePicker
            // 
            this.fechaExtrenoDateTimePicker.CustomFormat = "yyy/MM/dd";
            this.fechaExtrenoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaExtrenoDateTimePicker.Location = new System.Drawing.Point(246, 159);
            this.fechaExtrenoDateTimePicker.Name = "fechaExtrenoDateTimePicker";
            this.fechaExtrenoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaExtrenoDateTimePicker.TabIndex = 6;
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(477, 110);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(75, 23);
            this.buscar.TabIndex = 7;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // Nuevo
            // 
            this.Nuevo.Location = new System.Drawing.Point(164, 211);
            this.Nuevo.Name = "Nuevo";
            this.Nuevo.Size = new System.Drawing.Size(75, 23);
            this.Nuevo.TabIndex = 8;
            this.Nuevo.Text = "Nuevo";
            this.Nuevo.UseVisualStyleBackColor = true;
            this.Nuevo.Click += new System.EventHandler(this.Nuevo_Click);
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(272, 210);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 23);
            this.Guardar.TabIndex = 9;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(391, 210);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(75, 23);
            this.Eliminar.TabIndex = 10;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // PeliculaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 261);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.Nuevo);
            this.Controls.Add(this.buscar);
            this.Controls.Add(peliculaIdLabel);
            this.Controls.Add(this.peliculaIdTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(fechaExtrenoLabel);
            this.Controls.Add(this.fechaExtrenoDateTimePicker);
            this.Name = "PeliculaForm";
            this.Text = "PeliculaForm";
            this.Load += new System.EventHandler(this.PeliculaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox peliculaIdTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.DateTimePicker fechaExtrenoDateTimePicker;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.Button Nuevo;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}