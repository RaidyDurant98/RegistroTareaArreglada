using RegistroTarea.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RegistroTarea.UI.Registros
{
    public partial class PeliculasForm : Form
    {
        public PeliculasForm()
        {
            InitializeComponent();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            var pelicula = BLL.PeliculasBLL.Buscar(Convert.ToInt32(PeliculaIdtextBox.Text));

            if (pelicula != null)
            {
                EstrenomaskedTextBox.Text = pelicula.Estreno;
                DescripciontextBox.Text = pelicula.Descripcion;
                CategoriatextBox.Text = pelicula.CategoriaId;
            }
            else
            {
                MessageBox.Show("No existe ninguna pelicula con ese ID...");
            }
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            PeliculaIdtextBox.Clear();
            EstrenomaskedTextBox.Clear();
            DescripciontextBox.Clear();
            CategoriatextBox.Clear();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            var pelicula = new Peliculas();

            pelicula.Estreno = EstrenomaskedTextBox.Text;
            pelicula.Descripcion = DescripciontextBox.Text;
            pelicula.CategoriaId = CategoriatextBox.Text;

            if (pelicula != null)
            {
                BLL.PeliculasBLL.Guardar(pelicula);
                MessageBox.Show("La pelicula se a guardado con exito...");
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            var pelicula = BLL.PeliculasBLL.Buscar(Convert.ToInt32(PeliculaIdtextBox.Text));

            if (pelicula != null)
            {
                BLL.PeliculasBLL.Eliminar(pelicula);
                MessageBox.Show("Se ha eliminado la pelicula...");
                Limpiar();
            }
            else
            {
                MessageBox.Show("No se ha podido eliminar la pelicula...");
            }
        }
    }
}
