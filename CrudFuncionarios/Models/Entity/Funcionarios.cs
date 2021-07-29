using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CrudFuncionarios.Models.Entity
{
    [Table("Funcionario")]
    public class Funcionarios
    {
        [Display(Description = "Codigo do Usuario")]
        public int Id { get; set; }
        
        [Display(Description = "Nome do Usuario")]
        public string Nome { get; set; }

        [Display(Description = "Nome do Usuario")]
        public int Idade { get; set; }

        [Display(Description = "Nome do Usuario")]
        public float Salario { get; set; }

        [Display(Description = "CPF do Usuario")]
        public string CPF { get; set; }

        [ForeignKey("Departamento")]
        public int IdDepartamento { get; set; }
        public Departamento Departamento { get; set; }

    }
}
