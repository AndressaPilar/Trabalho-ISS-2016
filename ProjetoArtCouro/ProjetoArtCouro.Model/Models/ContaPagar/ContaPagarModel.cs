﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoArtCouro.Model.Models.ContaPagar
{
    public class ContaPagarModel
    {
        public int? CodigoContaPagar { get; set; }

        [Display(Name = "CodeBuy", ResourceType = typeof(Mensagens))]
        public int? CodigoCompra { get; set; }

        [Display(Name = "ProviderCode", ResourceType = typeof(Mensagens))]
        public int? CodigoFornecedor { get; set; }

        [Display(Name = "IssuanceDate", ResourceType = typeof(Mensagens))]
        public string DataEmissao { get; set; }

        [Display(Name = "DueDate", ResourceType = typeof(Mensagens))]
        public string DataVencimento { get; set; }

        [Display(Name = "ProviderName", ResourceType = typeof(Mensagens))]
        public string NomeFornecedor { get; set; }

        [Display(Name = "CPFCNPJ", ResourceType = typeof(Mensagens))]
        public string CPFCNPJ { get; set; }

        [Display(Name = "Status", ResourceType = typeof(Mensagens))]
        public int? StatusId { get; set; }

        [Display(Name = "Status", ResourceType = typeof(Mensagens))]
        public string Status { get; set; }

        [Display(Name = "ValueDocument", ResourceType = typeof(Mensagens))]
        public string ValorDocumento { get; set; }

        [Display(Name = "Paid", ResourceType = typeof(Mensagens))]
        public bool Pago { get; set; }
    }
}
