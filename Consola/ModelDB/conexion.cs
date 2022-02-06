using System;

using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;

namespace ModelDB
{
    public class Class1 : DbContext
    {
        public DbSet<film> films { get; set; }
        public DbSet<inventory> inventorys { get; set; }
        public DbSet<language> languages { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder opciones)
        {
            opciones.UseSqlServer("Server= DESKTOP-84TGTM8 ; initial catalog = dvd; trusted_connection = true; ");

            
        }
    }
}
