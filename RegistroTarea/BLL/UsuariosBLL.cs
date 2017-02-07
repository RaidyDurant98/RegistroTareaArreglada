using RegistroTarea.DAL;
using RegistroTarea.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RegistroTarea.BLL
{
    public class UsuariosBLL
    {
        public static bool Guardar(Usuarios usuarioNuevo)
        {
            bool interruptor = false;

            using(var conec = new RegistroTareaDb())
            {
                try
                {
                    conec.Usuario.Add(usuarioNuevo);
                    conec.SaveChanges();
                    interruptor = true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                    //throw;
                }
            }

            return interruptor;
        }

        public static Usuarios Buscar(int idUsuario)
        {
            var usuario = new Usuarios();

            using(var conec = new RegistroTareaDb())
            {
                try
                {
                    usuario = conec.Usuario.Find(idUsuario);
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return usuario;
        }

        public static bool Eliminar(Usuarios usuarioNuevo)
        {
            bool interruptor = false;

            using(var conec = new RegistroTareaDb())
            {
                try
                {
                    conec.Entry(usuarioNuevo).State = EntityState.Deleted;
                    conec.SaveChanges();
                    interruptor = true;
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return interruptor;
        }
    }
}
