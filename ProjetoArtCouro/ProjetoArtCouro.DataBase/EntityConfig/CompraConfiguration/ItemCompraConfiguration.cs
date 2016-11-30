using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoArtCouro.DataBase.EntityConfig.CompraConfiguration
{
    public class ItemCompraConfiguration : EntityTypeConfiguration<ItemCompra>
    {
        public ItemCompraConfiguration()
        {
            ToTable("ItemCompra");

            Property(x => x.ItemCompraId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.ItemCompraCodigo)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.ProdutoCodigo)
                .IsRequired()
                .HasColumnType("int");

            Property(x => x.ProdutoNome)
                .IsRequired()
                .HasColumnType("varchar");

            Property(x => x.Quantidade)
                .IsRequired()
                .HasColumnType("int");

            Property(x => x.PrecoVenda)
                .IsRequired()
                .HasColumnType("decimal");

            Property(x => x.ValorBruto)
                .IsRequired()
                .HasColumnType("decimal");

            Property(x => x.ValorLiquido)
                .IsRequired()
                .HasColumnType("decimal");
        }
    }
}
