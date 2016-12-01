using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoArtCouro.DataBase.EntityConfig.PessoaConfiguration
{
    public class PessoaJuridicaConfiguration : EntityTypeConfiguration<PessoaJuridica>
    {
        public PessoaJuridicaConfiguration()
        {
            ToTable("PessoaJuridica");

            HasKey(x => x.PessoaId);

            Property(x => x.PessoaJuridicaCodigo)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.CNPJ)
                .IsRequired()
                .HasColumnType("varchar")
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_CNPJ", 1) { IsUnique = true }));

            Property(x => x.Contato)
                .IsOptional()
                .HasMaxLength(100)
                .HasColumnType("varchar");
        }
    }
}
