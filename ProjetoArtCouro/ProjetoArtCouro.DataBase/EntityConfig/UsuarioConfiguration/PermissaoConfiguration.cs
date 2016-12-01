using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoArtCouro.DataBase.EntityConfig.UsuarioConfiguration
{
    public class PermissaoConfiguration : EntityTypeConfiguration<Permissao>
    {
        public PermissaoConfiguration()
        {
            ToTable("Permissao");

            Property(x => x.PermissaoId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.PermissaoCodigo)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.PermissaoNome)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("varchar");

            Property(x => x.AcaoNome)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("varchar");

            HasMany(x => x.GrupoPermissao)
                .WithMany(x => x.Permissoes)
                .Map(m =>
                {
                    m.MapLeftKey("PermissaoId");
                    m.MapRightKey("GrupoPermissaoId");
                    m.ToTable("PermissaoGrupoPermissao");
                });

            HasMany(x => x.Usuarios);
        }
    }
}
