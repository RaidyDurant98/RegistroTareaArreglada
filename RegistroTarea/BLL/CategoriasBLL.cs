using RegistroTarea.DAL;
using RegistroTarea.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace RegistroTarea.BLL
{
    public class CategoriasBLL
    {
        public static bool Guardar(Categorias categoriaNueva)
        {
            bool interruptor = false;

            using(var conec = new RegistroTareaDb())
            {
                try
                {
                    conec.Categoria.Add(categoriaNueva);
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

        public static Categorias Buscar(int idCategoria)
        {
            var categoria = new Categorias();

            using(var conec = new RegistroTareaDb())
            {
                try
                {
                    categoria = conec.Categoria.Find(idCategoria);
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return categoria;
        }

        public static bool Eliminar(Categorias categoriaNueva)
        {
            bool interruptor = false;

            using(var conec = new RegistroTareaDb())
            {
                try
                {
                    conec.Entry(categoriaNueva).State = EntityState.Deleted;
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
