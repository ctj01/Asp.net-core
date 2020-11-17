using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace curso_vax
{
    class appventacuros : DbContext
    {
        private const string conexion_string = @"Data Source=DESKTOP-3RO8NFF\SQLEXPRESS;Initial Catalog=curso;Integrated Security=True";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(conexion_string);
        }
        public DbSet<Tcurso> Tcurso { get; set;}
        public DbSet<Tprecio> Tprecio { get; set;}
        public DbSet<Tcomentario> Tcomentario { get; set;}
        public DbSet <Instructor> instructor { get; set; }
        public DbSet<Instructorcurso> Instructorcurso { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tprecio>().HasOne(p => p.Tcurso).WithOne(a => a.PrecioPromocion)
                .HasForeignKey<Tprecio>(a => a.Cursoid);

            modelBuilder.Entity<Tcomentario>().HasOne(p => p.Tcurso).WithMany(a => a.Comments)
                .HasForeignKey(a => a.Cursoid);
            modelBuilder.Entity<Instructorcurso>().HasKey(b => new { b.Cursoid, b.Instructorid });

        }
    }
}
