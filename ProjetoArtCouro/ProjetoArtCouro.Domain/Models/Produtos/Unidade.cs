﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoArtCouro.Domain.Models.Produtos
{
    public class Unidade
    {
        public Guid UnidadeId { get; set; }
        public int UnidadeCodigo { get; set; }
        public string UnidadeNome { get; set; }
        public virtual ICollection<Produto> Produto { get; set; }

        public void Validar()
        {
            AssertionConcern.AssertArgumentNotEquals(0, UnidadeCodigo, string.Format(Erros.NotZeroParameter, "UnidadeCodigo"));
        }
    }
}
