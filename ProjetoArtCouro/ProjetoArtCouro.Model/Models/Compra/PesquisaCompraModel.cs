using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoArtCouro.Model.Models.Compra
{
    public class PesquisaCompraModel
    {
        [Display(Name = "CodeBuy", ResourceType = typeof(Mensagens))]
        public int? CodigoCompra { get; set; }

        [Display(Name = "ProviderCode", ResourceType = typeof(Mensagens))]
        public int? CodigoFornecedor { get; set; }

        [Display(Name = "RegistrationDate", ResourceType = typeof(Mensagens))]
        public string DataCadastro { get; set; }

        [Display(Name = "ProviderName", ResourceType = typeof(Mensagens))]
        public string NomeFornecedor { get; set; }

        [Display(Name = "CPFCNPJ", ResourceType = typeof(Mensagens))]
        public string CPFCNPJ { get; set; }

        [Display(Name = "Status", ResourceType = typeof(Mensagens))]
        public int? StatusId { get; set; }
    }
}
