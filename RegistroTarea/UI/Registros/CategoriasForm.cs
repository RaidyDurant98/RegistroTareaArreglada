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
    public partial class CategoriasForm : Form
    {
        public CategoriasForm()
        {
            InitializeComponent();
        }

        private void CategoriasForm_Load(object sender, EventArgs e)
        {

        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            var categoria = BLL.CategoriasBLL.Buscar(Convert.ToInt32(CategoriaIdtextBox.Text));

            if (categoria != null)
            {
                DescripciontextBox.Text = categoria.Descripcion;
            }
            else
            {
                MessageBox.Show("No existe ninguna categoria creada con este ID...");
            }
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            CategoriaIdtextBox.Clear();
            DescripciontextBox.Clear();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            var categoria = new Categorias();

            categoria.Descripcion = DescripciontextBox.Text;

            if (categoria != null)
            {
                BLL.CategoriasBLL.Guardar(categoria);
                MessageBox.Show("La categoria se a guardado con exito...");
            }
            else
            {
                MessageBox.Show("No se pudo guardar la categoria...");
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            var categoria = BLL.CategoriasBLL.Buscar(Convert.ToInt32(CategoriaIdtextBox.Text));

            if (categoria != null)
            {
                BLL.CategoriasBLL.Eliminar(categoria);
                MessageBox.Show("Se elimino con exito la categoria...");
                Limpiar();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar la categoria...");
            }
        }
    }
}
