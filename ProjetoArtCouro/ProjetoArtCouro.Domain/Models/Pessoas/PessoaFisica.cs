using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoArtCouro.Domain.Models.Pessoas
{
    public class PessoaFisica
    {
        public Guid PessoaId { get; set; }
        public int PessoaFisicaCodigo { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Sexo { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        public virtual EstadoCivil EstadoCivil { get; set; }

        public void Validar()
        {
            AssertionConcern.AssertArgumentNotEmpty(CPF, Erros.EmptyCPF);
            AssertionConcern.AssertArgumentNotEmpty(RG, Erros.EmptyRG);
            AssertionConcern.AssertArgumentNotEmpty(Sexo, Erros.EmptySex);
            AssertionConcern.AssertArgumentNotNull(EstadoCivil, Erros.EmptyMaritalStatus);
        }
    }
}
