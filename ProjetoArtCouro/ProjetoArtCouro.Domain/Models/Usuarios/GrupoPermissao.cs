using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoArtCouro.Domain.Models.Usuarios
{
    public class GrupoPermissao
    {
        public Guid GrupoPermissaoId { get; set; }
        public int GrupoPermissaoCodigo { get; set; }
        public string GrupoPermissaoNome { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
        public virtual ICollection<Permissao> Permissoes { get; set; }
    }
}
