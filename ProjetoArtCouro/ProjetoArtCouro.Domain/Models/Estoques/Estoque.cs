using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoArtCouro.Domain.Models.Estoques
{
    public class Estoque
    {
        public Guid EstoqueId { get; set; }
        public int EstoqueCodigo { get; set; }
        public DateTime DataUltimaEntrada { get; set; }
        public int Quantidade { get; set; }
        public virtual Produto Produto { get; set; }
        public virtual Pessoa Fornecedor { get; set; }
    }
}
