using RegistroTarea.DAL;
using RegistroTarea.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RegistroTarea.UI.Consultas
{
    public partial class ConsultaPeliculas : Form
    {
        public ConsultaPeliculas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Peliculas> peliculasLista = new List<Peliculas>();
            var pelLista = new RegistroTareaDb();

            peliculasLista = pelLista.Pelicula.ToList();
            ListaPeliculasdataGridView.DataSource = peliculasLista;
        }
    }
}
