using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoArtCouro.Domain.Contracts.ICompra.IRepository
{
    public interface ICompraRepository : IDisposable
    {
        Compra ObterPorId(Guid id);
        Compra ObterPorCodigo(int codigo);
        Compra ObterPorCodigoComItensCompra(int codigo);
        List<Compra> ObterLista();
        List<Compra> ObterLista(int codigoCompra, int codigoFornecedor, DateTime dataCadastro, int statusCompra,
            string nomeFornecedor, string documento, int codigoUsuario);
        void Criar(Compra compra);
        void Atualizar(Compra compra);
        void Deletar(Compra compra);
    }
}
