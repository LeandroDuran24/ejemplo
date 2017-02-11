using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Registros.BLL;

namespace Registros.UI.Consultas
{
    public partial class ConsultaPelicula : Form
    {
        public ConsultaPelicula()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (desdedateTimePicker1.Value.Date <= hastadateTimePicker2.Value.Date)
                dataGridView1.DataSource = PeliculaEntidadBLL.GetList(desdedateTimePicker1.Value.Date, hastadateTimePicker2.Value.Date);
        }
    }
}
