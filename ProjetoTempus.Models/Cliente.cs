using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProjetoTempus.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do Cliente é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Informe o Nome do Cliente")]
        [StringLength(150, MinimumLength = 4)]
        public string Nome { get; set; }

        [Display(Name = "Informe o CPF do Cliente")]
        [Required(ErrorMessage = "O CPF do Cliente é obrigatório", AllowEmptyStrings = false)]
        [StringLength(14)]
        public string CPF { get; set; }

        [Required]
        [Range(typeof(DateTime), "01/01/1900", "01/01/2020",
        ErrorMessage = "Data de Nascimento {0} Precisa ser entre {1} e {2}")]
        [Display(Name = "Informe a Data de Nascimento")]
        public DateTime DataNascimento { get; set; }

        public DateTime DataCadastro { get; set; }

        [Display(Name = "Informe a Renda Familiar do Cliente (Opcional)")]
        public Nullable<double> RendaFamiliar { get; set; }
    }
}
