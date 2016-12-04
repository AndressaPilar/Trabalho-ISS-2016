using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoArtCouro.Domain.Contracts.IService.IPagamento
{
    public interface ICondicaoPagamentoService : IDisposable
    {
        List<CondicaoPagamento> ObterListaCondicaoPagamento();
        CondicaoPagamento ObterCondicaoPagamentoPorCodigo(int codigo);
        CondicaoPagamento CriarCondicaoPagamento(CondicaoPagamento condicaoPagamento);
        CondicaoPagamento AtualizarCondicaoPagamento(CondicaoPagamento condicaoPagamento);
        void ExcluirCondicaoPagamento(int condicaoPagamentoCodigo);
    }
}
