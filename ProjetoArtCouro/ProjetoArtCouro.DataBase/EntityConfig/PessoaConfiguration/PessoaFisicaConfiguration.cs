using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoArtCouro.DataBase.EntityConfig.PessoaConfiguration
{
    public class PessoaFisicaConfiguration : EntityTypeConfiguration<PessoaFisica>
    {
        public PessoaFisicaConfiguration()
        {
            ToTable("PessoaFisica");

            HasKey(x => x.PessoaId);

            Property(x => x.PessoaFisicaCodigo)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.CPF)
                .IsRequired()
                .HasColumnType("varchar")
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_CPF", 1) { IsUnique = true }));

            Property(x => x.RG)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(15);

            Property(x => x.Sexo)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(10);
        }
    }
}
