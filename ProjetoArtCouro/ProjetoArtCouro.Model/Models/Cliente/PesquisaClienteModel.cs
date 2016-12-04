using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoArtCouro.Model.Models.Cliente
{
    public class PesquisaClienteModel
    {
        [Display(Name = "Code", ResourceType = typeof(Mensagens))]
        public int? CodigoCliente { get; set; }

        [Display(Name = "Name", ResourceType = typeof(Mensagens))]
        public string Nome { get; set; }

        [Display(Name = "CPFCNPJ", ResourceType = typeof(Mensagens))]
        public string CPFCNPJ { get; set; }

        [Display(Name = "Email", ResourceType = typeof(Mensagens))]
        public string Email { get; set; }

        [Display(Name = "TypeOfPerson", ResourceType = typeof(Mensagens))]
        public bool EPessoaFisica { get; set; }
    }
}
