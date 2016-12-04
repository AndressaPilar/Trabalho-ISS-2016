using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoArtCouro.DataBase.EntityConfig.PagamentoConfiguration
{
    public class FormaPagamentoConfiguration : EntityTypeConfiguration<FormaPagamento>
    {
        public FormaPagamentoConfiguration()
        {
            ToTable("FormaPagamento");

            Property(x => x.FormaPagamentoId)
               .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.FormaPagamentoCodigo)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Descricao)
               .IsRequired()
               .HasMaxLength(30)
               .HasColumnType("varchar");

            Property(x => x.Ativo)
                .IsRequired()
                .HasColumnType("bit");
        }
    }
}
