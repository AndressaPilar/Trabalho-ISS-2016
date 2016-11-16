﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoArtCouro.Domain.Models.Pessoas
{
    public class Papel
    {
        public Guid PapelId { get; set; }
        public int PapelCodigo { get; set; }
        public string PapelNome { get; set; }
        public virtual ICollection<Pessoa> Pessoas { get; set; }
    }
}
