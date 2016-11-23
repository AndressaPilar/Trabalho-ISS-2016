using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoArtCouro.Domain.Contracts.ICompra.IRepository
{
    public interface IItemCompraRepository : IDisposable
    {
        ItemCompra ObterPorId(Guid id);
        ItemCompra ObterPorCodigo(int codigo);
        List<ItemCompra> ObterLista();
        ItemCompra Criar(ItemCompra itemCompra);
        void Atualizar(ItemCompra itemCompra);
        void Deletar(ItemCompra itemCompra);
    }
}
