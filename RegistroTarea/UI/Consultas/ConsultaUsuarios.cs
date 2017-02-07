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
    public partial class ConsultaUsuarios : Form
    {
        public ConsultaUsuarios()
        {
            InitializeComponent();
        }

        private void VerListaUsuariosbutton_Click(object sender, EventArgs e)
        {
            List<Usuarios> usuariosLista = new List<Usuarios>();
            var usLista = new RegistroTareaDb();

            usuariosLista = usLista.Usuario.ToList();
            ListaUsuariosdataGridView.DataSource = usuariosLista;
        }
    }
}
