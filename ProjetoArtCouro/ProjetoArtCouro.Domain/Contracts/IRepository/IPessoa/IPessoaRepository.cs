using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoArtCouro.Domain.Contracts.IRepository.IPessoa
{
    public interface IPessoaRepository : IDisposable
    {
        Pessoa ObterPorId(Guid id);
        Pessoa ObterPorCodigo(int codigo);
        Pessoa ObterPorCodigoComPessoaCompleta(int codigo);
        List<Pessoa> ObterListaComPessoaFisicaEJuridica();
        List<Pessoa> ObterListaComPessoaFisicaEJuridicaPorPapel(TipoPapelPessoaEnum papelCodigo);
        void Criar(Pessoa pessoa);
        void Atualizar(Pessoa pessoa);
        void Deletar(Pessoa pessoa);
    }
}
