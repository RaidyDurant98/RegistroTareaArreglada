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
    public class PeliculasBLL
    {
        public static bool Guardar(Peliculas peliculaNueva)
        {
            bool interruptor = false;

            using(var conec = new RegistroTareaDb())
            {
                try
                {
                    conec.Pelicula.Add(peliculaNueva);
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

        public static Peliculas Buscar(int idPelicula)
        {
            var pelicula = new Peliculas();

            using(var conec = new RegistroTareaDb())
            {
                try
                {
                    pelicula = conec.Pelicula.Find(idPelicula);
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return pelicula;
        }

        public static bool Eliminar(Peliculas peliculaNueva)
        {
            bool interruptor = false;

            using(var conec = new RegistroTareaDb())
            {
                try
                {
                    conec.Entry(peliculaNueva).State = EntityState.Deleted;
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
