using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoArtCouro.Domain.Contracts.IService.IProduto
{
    public interface IProdutoService : IDisposable
    {
        List<Produto> ObterListaProduto();
        List<Unidade> ObterListaUnidade();
        Produto ObterProdutoPorCodigo(int codigo);
        Produto CriarProduto(Produto produto);
        Produto AtualizarProduto(Produto produto);
        void ExcluirProduto(int produtoCodigo);
    }
}
