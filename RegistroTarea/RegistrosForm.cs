using RegistroTarea.UI.Consultas;
using RegistroTarea.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RegistroTarea
{
    public partial class RegistrosForm : Form
    {
        public RegistrosForm()
        {
            InitializeComponent();
        }

        private void registrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuariosForm us = new UsuariosForm();
            us.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoriasForm cat = new CategoriasForm();
            cat.Show();
        }

        private void peliculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PeliculasForm pel = new PeliculasForm();
            pel.Show();
        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaUsuarios conUs = new ConsultaUsuarios();
            conUs.Show();
        }

        private void categoriasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaCategorias conCat = new ConsultaCategorias();
            conCat.Show();
        }

        private void peliculasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaPeliculas conPel = new ConsultaPeliculas();
            conPel.Show();
        }
    }
}
