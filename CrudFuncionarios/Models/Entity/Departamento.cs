using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CrudFuncionarios.Models.Entity
{
    [Table("Departamento")]
    public class Departamento
    {
        [Display(Description = "Codigo do Usuario")]
        public int Id { get; set; }

        [Display(Description = "Nome do Departamento")]
        public string Nome { get; set; }

        public virtual List<Funcionarios> Funcionarios { get; set; }

        [ForeignKey("Chefia")]
        public int IdChefia { get; set; }

        public Chefia Chefia { get; set; }

    }
}
