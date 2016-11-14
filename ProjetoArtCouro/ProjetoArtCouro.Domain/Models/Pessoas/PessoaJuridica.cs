using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoArtCouro.Domain.Models.Pessoas
{
    public class PessoaJuridica
    {
        public Guid PessoaId { get; set; }
        public int PessoaJuridicaCodigo { get; set; }
        public string CNPJ { get; set; }
        public string Contato { get; set; }
        public virtual Pessoa Pessoa { get; set; }

        public void Validar()
        {
            AssertionConcern.AssertArgumentNotEmpty(CNPJ, Erros.EmptyCNPJ);
            AssertionConcern.AssertArgumentNotEmpty(Contato, Erros.EmptyContact);
        }
    }
}
