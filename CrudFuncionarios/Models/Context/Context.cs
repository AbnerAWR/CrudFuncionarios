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
        public DbSet<Funcionarios> Funcionarios { get; set; }
        public DbSet<Departamento> Departamento { get; set; }
        public DbSet<Chefia> Chefia { get; set; }
    }
}
