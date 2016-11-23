using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoArtCouro.Domain.Contracts.IRepository.IUsuario
{
    public interface IPermissaoRepository : IDisposable
    {
        Permissao ObterPermissaoPorCodigo(int codigo);
        List<Permissao> ObterLista();
    }
}
