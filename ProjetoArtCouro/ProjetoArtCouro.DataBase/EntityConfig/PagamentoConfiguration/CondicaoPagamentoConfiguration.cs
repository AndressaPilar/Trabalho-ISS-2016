using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoArtCouro.DataBase.EntityConfig.PagamentoConfiguration
{
    public class CondicaoPagamentoConfiguration : EntityTypeConfiguration<CondicaoPagamento>
    {
        public CondicaoPagamentoConfiguration()
        {
            ToTable("CondicaoPagamento");

            Property(x => x.CondicaoPagamentoId)
               .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.CondicaoPagamentoCodigo)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Descricao)
               .IsRequired()
               .HasMaxLength(30)
               .HasColumnType("varchar");

            Property(x => x.Ativo)
                .IsRequired()
                .HasColumnType("bit");

            Property(x => x.QuantidadeParcelas)
                .IsRequired()
                .HasColumnType("int");
        }
    }
}
