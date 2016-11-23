using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoArtCouro.Domain.Contracts.IRepository.IVenda
{
    public interface IItemVendaRepository : IDisposable
    {
        ItemVenda ObterPorId(Guid id);
        ItemVenda ObterPorCodigo(int codigo);
        List<ItemVenda> ObterLista();
        ItemVenda Criar(ItemVenda itemVenda);
        void Atualizar(ItemVenda itemVenda);
        void Deletar(ItemVenda itemVenda);
    }
}
