using System;

namespace Estudo_FluentAPI.Models
{
    public class Produto : Base
    {
        public string Nome { get; set; }
        public DateTime DataCadastro { get; set; }
        public decimal Preco { get; set; }
    }
}