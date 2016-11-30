using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoArtCouro.Domain.Contracts.IRepository.IPessoa
{
    public interface IEnderecoRepository : IDisposable
    {
        Endereco ObterPorId(Guid id);
        List<Endereco> ObterLista();
        Endereco Criar(Endereco endereco);
        void Atualizar(Endereco endereco);
        void Deletar(Endereco endereco);
    }
}
