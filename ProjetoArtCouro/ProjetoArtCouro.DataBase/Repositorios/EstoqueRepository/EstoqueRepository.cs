﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoArtCouro.DataBase.Repositorios.EstoqueRepository
{
    public class EstoqueRepository : IEstoqueRepository
    {
        private readonly DataBaseContext _context;
        public EstoqueRepository(DataBaseContext context)
        {
            _context = context;
        }

        public Estoque ObterPorId(Guid id)
        {
            return _context.Estoques.FirstOrDefault(x => x.EstoqueId.Equals(id));
        }

        public Estoque ObterPorCodigo(int codigo)
        {
            return _context.Estoques.FirstOrDefault(x => x.EstoqueCodigo.Equals(codigo));
        }

        public List<Estoque> ObterLista()
        {
            return _context.Estoques.ToList();
        }

        public Estoque ObterPorCodigoProduto(int codigoProduto)
        {
            return
                _context.Estoques.Include("Produto").FirstOrDefault(x => x.Produto.ProdutoCodigo.Equals(codigoProduto));
        }

        public List<Estoque> ObterLista(string descricaoProduto, int codigoProduto, int quantidaEstoque, string nomeFornecedor,
            int codigoFornecedor)
        {
            var query = from estoque in _context.Estoques
                .Include("Produto")
                .Include("Fornecedor")
                        select estoque;

            if (!codigoProduto.Equals(0))
            {
                query = query.Where(x => x.Produto.ProdutoCodigo == codigoProduto);
            }

            if (!quantidaEstoque.Equals(0))
            {
                query = query.Where(x => x.Quantidade == quantidaEstoque);
            }

            if (!codigoFornecedor.Equals(0))
            {
                query = query.Where(x => x.Fornecedor.PessoaCodigo == codigoFornecedor);
            }

            if (!string.IsNullOrEmpty(descricaoProduto))
            {
                query = query.Where(x => x.Produto.ProdutoNome.Contains(descricaoProduto));
            }

            if (!string.IsNullOrEmpty(nomeFornecedor))
            {
                query = query.Where(x => x.Fornecedor.Nome.Contains(nomeFornecedor));
            }

            return query.ToList();
        }

        public void Criar(Estoque estoque)
        {
            _context.Estoques.Add(estoque);
            _context.SaveChanges();
        }

        public void Atualizar(Estoque estoque)
        {
            _context.Entry(estoque).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Deletar(Estoque estoque)
        {
            _context.Estoques.Remove(estoque);
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
