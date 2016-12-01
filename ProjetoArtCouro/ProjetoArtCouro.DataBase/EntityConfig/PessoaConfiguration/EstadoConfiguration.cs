using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoArtCouro.DataBase.EntityConfig.PessoaConfiguration
{
    public class EstadoConfiguration : EntityTypeConfiguration<Estado>
    {
        public EstadoConfiguration()
        {
            ToTable("Estado");

            Property(x => x.EstadoId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.EstadoCodigo)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(state => state.EstadoNome)
                .IsRequired()
                .HasMaxLength(250)
                .HasColumnType("varchar");

            //Relacionamento 1 : N
            HasMany(x => x.Endereco)
                .WithRequired(x => x.Estado);
        }
    }
}
