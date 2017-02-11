using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Registros.UI.Consultas;
using Registros.UI.Registros;

namespace Registros
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void registrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void peliculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PeliculaForm p = new PeliculaForm();
            p.Show();
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void peliculaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaPelicula c = new ConsultaPelicula();
            c.Show();
        }
    }
}
