﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoArtCouro.Domain.Contracts.IService.IVenda
{
    public interface IVendaService : IDisposable
    {
        List<Venda> PesquisarVenda(int codigoVenda, int codigoCliente, DateTime dataCadastro,
        int statusVenda, string nomeCliente, string documento, int codigoUsuario);
        Venda ObterVendaPorCodigo(int codigoVenda);
        void CriarVenda(Venda venda);
        void AtualizarVenda(Venda venda);
        void ExcluirVenda(int codigoVenda);
    }
}