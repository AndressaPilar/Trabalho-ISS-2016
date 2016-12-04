using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoArtCouro.DataBase.EntityConfig.VendaConfiguration
{
    public class ContaReceberConfiguration : EntityTypeConfiguration<ContaReceber>
    {
        public ContaReceberConfiguration()
        {
            ToTable("ContaReceber");

            Property(x => x.ContaReceberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.ContaReceberCodigo)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.DataVencimento)
                .IsRequired()
                .HasColumnType("datetime2");

            Property(x => x.ValorDocumento)
                .IsRequired()
                .HasColumnType("decimal");

            Property(x => x.StatusContaReceber)
                .IsRequired()
                .HasColumnType("int");

            Property(x => x.Recebido)
                .IsRequired()
                .HasColumnType("bit");
        }
    }
}
