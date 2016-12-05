using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoArtCouro.Model.Models.Venda
{
    public class PesquisaVendaModel
    {
        [Display(Name = "SaleCode", ResourceType = typeof(Mensagens))]
        public int? CodigoVenda { get; set; }

        [Display(Name = "ClientCode", ResourceType = typeof(Mensagens))]
        public int? CodigoCliente { get; set; }

        [Display(Name = "RegistrationDate", ResourceType = typeof(Mensagens))]
        public string DataCadastro { get; set; }

        [Display(Name = "ClientName", ResourceType = typeof(Mensagens))]
        public string NomeCliente { get; set; }

        [Display(Name = "CPFCNPJ", ResourceType = typeof(Mensagens))]
        public string CPFCNPJ { get; set; }

        [Display(Name = "Status", ResourceType = typeof(Mensagens))]
        public int? StatusId { get; set; }
    }
}
