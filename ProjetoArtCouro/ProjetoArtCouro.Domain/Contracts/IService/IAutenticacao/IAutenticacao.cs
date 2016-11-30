using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoArtCouro.Domain.Contracts.IService.IAutenticacao
{
    public interface IAutenticacao : IDisposable
    {
        Usuario AutenticarUsuario(string usuarioNome, string senha);
    }
}
