using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoArtCouro.Model.Models.Usuario
{
    public class PesquisaUsuarioModel
    {
        [Display(Name = "Name", ResourceType = typeof(Mensagens))]
        public string UsuarioNome { get; set; }

        [Display(Name = "Active", ResourceType = typeof(Mensagens))]
        public bool? Ativo { get; set; }

        [Display(Name = "Groups", ResourceType = typeof(Mensagens))]
        public int? GrupoId { get; set; }
    }
}
