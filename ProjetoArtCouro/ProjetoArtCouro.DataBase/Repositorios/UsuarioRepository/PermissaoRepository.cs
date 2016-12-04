﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoArtCouro.DataBase.Repositorios.UsuarioRepository
{
    public class PermissaoRepository : IPermissaoRepository
    {
        private readonly DataBaseContext _context;
        public PermissaoRepository(DataBaseContext context)
        {
            _context = context;
        }

        public Permissao ObterPermissaoPorCodigo(int codigo)
        {
            return _context.Permissoes.FirstOrDefault(x => x.PermissaoCodigo.Equals(codigo));
        }

        public List<Permissao> ObterLista()
        {
            return _context.Permissoes.ToList();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
