﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoArtCouro.Domain.Contracts.IRepository.IPessoa
{
    public interface IPapelRepository : IDisposable
    {
        Papel ObterPorId(Guid id);
        Papel ObterPorCodigo(int codigo);
        List<Papel> ObterLista();
        void Criar(Papel papel);
        void Atualizar(Papel papel);
        void Deletar(Papel papel);
    }
}
