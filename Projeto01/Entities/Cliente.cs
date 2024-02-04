using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01.Entities
{
    // Definição da classe
    public class Cliente
    {
        // Propriedades
        public Guid Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
