﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoArtCouro.Domain.Contracts.IRepository.IVenda
{
    public interface IVendaRepository : IDisposable
    {
        Venda ObterPorId(Guid id);
        Venda ObterPorCodigo(int codigo);
        Venda ObterPorCodigoComItensVenda(int codigo);
        List<Venda> ObterLista();
        List<Venda> ObterLista(int codigoVenda, int codigoCliente, DateTime dataCadastro, int statusVenda,
            string nomeCliente, string documento, int codigoUsuario);
        void Criar(Venda venda);
        void Atualizar(Venda venda);
        void Deletar(Venda venda);
    }
}
