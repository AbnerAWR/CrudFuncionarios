using CrudFuncionarios.Models.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudFuncionarios.Models.Context
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> option) : base(option)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Chefia>()
                 .HasMany(e => e.Departamentos)
                 .WithOne(e => e.Chefia)
                 .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Departamento>()
                .HasMany(s => s.Funcionarios)
                .WithOne(s => s.Departamento)
                .OnDelete(DeleteBehavior.Restrict);
        }


        public DbSet<Funcionarios> Funcionarios { get; set; }
        public DbSet<Departamento> Departamento { get; set; }
        public DbSet<Chefia> Chefia { get; set; }

      
    }
}
