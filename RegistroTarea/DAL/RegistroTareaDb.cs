using RegistroTarea.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace RegistroTarea.DAL
{
    public class RegistroTareaDb : DbContext
    {
        public RegistroTareaDb() : base("ConStr")
        {

        }

        public DbSet<Usuarios> Usuario { get; set; }
        public DbSet<Categorias> Categoria { get; set; }
        public DbSet<Peliculas> Pelicula { get; set; }
    }
}
