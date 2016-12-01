using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoArtCouro.DataBase.EntityConfig.PessoaConfiguration
{
    public class PapelConfiguration : EntityTypeConfiguration<Papel>
    {
        public PapelConfiguration()
        {
            ToTable("Papel");

            Property(x => x.PapelId)
               .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.PapelCodigo)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.PapelNome)
                .IsRequired()
                .HasMaxLength(250)
                .HasColumnType("varchar");

            HasMany(x => x.Pessoas);
        }
    }
}
