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
    public partial class UsuariosForm : Form
    {
        public UsuariosForm()
        {
            InitializeComponent();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            var usuario = BLL.UsuariosBLL.Buscar(Convert.ToInt32(UsuarioIdtextBox.Text));

            if(usuario != null)
            {
                NombretextBox.Text = usuario.Nombre;
                ClavetextBox.Text = usuario.Clave;
            }
            else
            {
                MessageBox.Show("No existe ningun usuario con ese ID...");
            }
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            UsuarioIdtextBox.Clear();
            NombretextBox.Clear();
            ClavetextBox.Clear();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            var usuario = new Usuarios();

            usuario.Nombre = NombretextBox.Text;
            usuario.Clave = ClavetextBox.Text;

            if (usuario != null)
            {
                BLL.UsuariosBLL.Guardar(usuario);
                MessageBox.Show("El usuario se a guardado con exito...");
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            var usuario = BLL.UsuariosBLL.Buscar(Convert.ToInt32(UsuarioIdtextBox.Text));

            if (usuario != null)
            {
                BLL.UsuariosBLL.Eliminar(usuario);
                MessageBox.Show("El usuario se elimino con exito...");
                Limpiar();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar el usuario...");
            }
        }
    }
}
