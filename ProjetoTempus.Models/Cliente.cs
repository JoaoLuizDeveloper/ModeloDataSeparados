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
        [Display(Name = "Informe a nome do Cliente")]
        [StringLength(150, MinimumLength = 4)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O CPF do Cliente é obrigatório", AllowEmptyStrings = false)]
        [StringLength(14)]
        public string CPF { get; set; }

        [Required]
        public DateTime DataNacimento { get; set; }

        public DateTime DataCadastro { get; set; }


        [Range(0, 10000000000)]
        public double RendaFamiliar { get; set; }
    }
}
