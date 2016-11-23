using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoArtCouro.Domain.Contracts.IRepository.IPessoa
{
    public interface IEstadoCivilRepository : IDisposable
    {
        EstadoCivil ObterPorId(Guid id);
        EstadoCivil ObterPorCodigo(int codigo);
        List<EstadoCivil> ObterLista();
        void Criar(EstadoCivil estadoCivil);
        void Atualizar(EstadoCivil estadoCivil);
        void Deletar(EstadoCivil estadoCivil);
    }
}
