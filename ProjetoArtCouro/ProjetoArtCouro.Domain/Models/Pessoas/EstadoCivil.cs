using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoArtCouro.Domain.Models.Pessoas
{
    public class EstadoCivil
    {
        public Guid EstadoCivilId { get; set; }
        public int EstadoCivilCodigo { get; set; }
        public string EstadoCivilNome { get; set; }
        public virtual ICollection<PessoaFisica> PessoaFisica { get; set; }
    }
}
