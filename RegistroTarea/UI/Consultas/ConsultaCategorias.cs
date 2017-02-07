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
    public partial class ConsultaCategorias : Form
    {
        public ConsultaCategorias()
        {
            InitializeComponent();
        }

        private void VerListabutton_Click(object sender, EventArgs e)
        {
            List<Categorias> categoriasLista = new List<Categorias>();
            var catLista = new RegistroTareaDb();

            categoriasLista = catLista.Categoria.ToList();
            ListaCategoriasdataGridView.DataSource = categoriasLista;
        }
    }
}
