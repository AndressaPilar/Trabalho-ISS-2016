﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoArtCouro.Domain.Models.Usuarios
{
    public class Usuario
    {
        public Guid UsuarioId { get; set; }
        public int UsuarioCodigo { get; set; }
        public string UsuarioNome { get; set; }
        public string Senha { get; set; }
        public bool Ativo { get; set; }
        public virtual Venda Venda { get; set; }
        public virtual Compra Compra { get; set; }
        public virtual GrupoPermissao GrupoPermissao { get; set; }
        public virtual ICollection<Permissao> Permissoes { get; set; }

        public void Validar()
        {
            AssertionConcern.AssertArgumentLength(UsuarioNome, 3, 250, Erros.InvalidUserName);
            PasswordAssertionConcern.AssertIsValid(Senha);
        }
    }
}
