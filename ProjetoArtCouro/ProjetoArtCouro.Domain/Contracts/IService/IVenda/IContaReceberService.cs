﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoArtCouro.Domain.Contracts.IService.IVenda
{
    public interface IContaReceberService : IDisposable
    {
        List<ContaReceber> PesquisarContaReceber(int codigoVenda, int codigoCliente, DateTime dataEmissao,
            DateTime dataVencimento, int statusContaReceber, string nomeCliente, string documento, int codigoUsuario);
        void ReceberContas(List<ContaReceber> contasReceber);
    }
}
