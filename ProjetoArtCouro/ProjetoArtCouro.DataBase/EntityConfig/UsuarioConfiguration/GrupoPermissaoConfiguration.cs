using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoArtCouro.DataBase.EntityConfig.UsuarioConfiguration
{
    public class GrupoPermissaoConfiguration : EntityTypeConfiguration<GrupoPermissao>
    {
        public GrupoPermissaoConfiguration()
        {
            ToTable("GrupoPermissao");

            Property(x => x.GrupoPermissaoId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.GrupoPermissaoCodigo)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.GrupoPermissaoNome)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("varchar");

            HasMany(x => x.Permissoes);

            //Relacionamento 1 : N
            HasMany(x => x.Usuarios)
                .WithRequired(x => x.GrupoPermissao);
        }
    }
