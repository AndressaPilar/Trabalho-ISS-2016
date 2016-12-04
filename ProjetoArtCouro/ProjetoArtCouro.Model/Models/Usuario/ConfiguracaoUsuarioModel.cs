using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoArtCouro.Model.Models.Usuario
{
    public class ConfiguracaoUsuarioModel
    {
        [Required(ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Erros))]
        [Display(Name = "Users", ResourceType = typeof(Mensagens))]
        public int? UsuarioId { get; set; }

        [Required(ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Erros))]
        [Display(Name = "Permissions", ResourceType = typeof(Mensagens))]
        public string PermissaoId { get; set; }

        public List<PermissaoModel> Permissoes { get; set; }
    }
}
