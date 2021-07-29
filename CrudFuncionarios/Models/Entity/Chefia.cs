using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CrudFuncionarios.Models.Entity
{
    [Table("Chefia")]
    public class Chefia
    {
        [Display(Description = "Codigo do Usuario")]
        public int Id { get; set; }
        
        [Display(Description = "Nome Chefia")]
        public string Nome { get; set; }

        public virtual List<Departamento> Departamentos { get; set; }
    }
}
