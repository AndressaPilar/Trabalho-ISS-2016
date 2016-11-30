﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoArtCouro.Domain.Contracts.IRepository.IUsuario
{
    public interface IUsuarioRepository : IDisposable
    {
        Usuario ObterPorId(Guid id);
        Usuario ObterPorCodigo(int codigo);
        Usuario ObterPorCodigoComPermissoes(int codigo);
        Usuario ObterPorCodigoComPermissoesEGrupo(int codigo);
        Usuario ObterPorUsuarioNome(string usuarioNome);
        Usuario ObterComPermissoesPorUsuarioNome(string usuarioNome);
        List<Usuario> ObterLista();
        List<Usuario> ObterListaComPermissoes();
        List<Usuario> ObterLista(string nome, int? codigoGrupo, bool? ativo);
        void Criar(Usuario usuario);
        void Atualizar(Usuario usuario);
        void Deletar(Usuario usuario);
    }
}