using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoArtCouro.Domain.Contracts.IRepository.IPagamento
{
    public interface IFormaPagamentoRepository : IDisposable
    {
        FormaPagamento ObterPorId(Guid id);
        FormaPagamento ObterPorCodigo(int codigo);
        List<FormaPagamento> ObterLista();
        FormaPagamento Criar(FormaPagamento formaPagamento);
        FormaPagamento Atualizar(FormaPagamento formaPagamento);
        void Deletar(FormaPagamento formaPagamento);
    }
}
