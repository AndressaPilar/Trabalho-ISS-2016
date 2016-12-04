using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoArtCouro.Model.Models.FormaPagamento
{
    public class FormaPagamentoModel
    {
        public int? FormaPagamentoCodigo { get; set; }

        [Required(ErrorMessageResourceType = typeof(Erros), ErrorMessageResourceName = "RequiredField")]
        [Display(Name = "Description", ResourceType = typeof(Mensagens))]
        public string Descricao { get; set; }

        [Required(ErrorMessageResourceType = typeof(Erros), ErrorMessageResourceName = "RequiredField")]
        [Display(Name = "Active", ResourceType = typeof(Mensagens))]
        public bool Ativo { get; set; }
    }
}
