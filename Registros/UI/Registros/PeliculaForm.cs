using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Registros.Entidades;

namespace Registros.UI.Registros
{
    public partial class PeliculaForm : Form
    {
        public PeliculaForm()
        {
            InitializeComponent();
        }

       

        private void PeliculaForm_Load(object sender, EventArgs e)
        {
           

        }

        public  void Limpiar()
        {
            nombreTextBox.Clear();
            peliculaIdTextBox.Clear();
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        public bool Validar()
        {
            if(string.IsNullOrEmpty(nombreTextBox.Text))
            {
                errorProvider.SetError(nombreTextBox, "Favor Completar");
                return false;
            }
            return true;
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            var conn = new PeliculaEntidad();
            conn.Nombre = nombreTextBox.Text;
            conn.Fecha = fechaExtrenoDateTimePicker.Value.Date;

            if(!Validar())
            {
                MessageBox.Show("Error");
            }
            else
            {
                BLL.PeliculaEntidadBLL.Guardar(conn);
                MessageBox.Show("Correcto");
            }


        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            var conn = BLL.PeliculaEntidadBLL.Buscar(Convert.ToInt32(peliculaIdTextBox.Text));

            if(conn != null)
            {
                BLL.PeliculaEntidadBLL.Eliminar(conn);
                MessageBox.Show("Correcto");
            }
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            var conn = BLL.PeliculaEntidadBLL.Buscar(Convert.ToInt32(peliculaIdTextBox.Text));

            if(conn!=null)
            {
                nombreTextBox.Text=conn.Nombre;
                MessageBox.Show("Correcto");
            }

        }
    }
}
