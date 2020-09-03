using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoTempus.Models.ViewModels
{
    public class ClienteVM
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataCadastro { get; set; }
        public Nullable<double> RendaFamiliar { get; set; }
    }
}
