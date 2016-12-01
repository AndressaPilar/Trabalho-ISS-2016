using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoArtCouro.DataBase.EntityConfig.PessoaConfiguration
{
    public class EstadoCivilConfiguration : EntityTypeConfiguration<EstadoCivil>
    {
        public EstadoCivilConfiguration()
        {
            ToTable("EstadoCivil");

            Property(x => x.EstadoCivilId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.EstadoCivilCodigo)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.EstadoCivilNome)
                .IsRequired()
                .HasMaxLength(250)
                .HasColumnType("varchar");

            //Relacionamento 1 : N
            HasMany(x => x.PessoaFisica)
                .WithRequired(x => x.EstadoCivil);
        }
    }
}
