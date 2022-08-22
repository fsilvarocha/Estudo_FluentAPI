using Estudo_FluentAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Estudo_FluentAPI.Mapping
{
    public class ProdutoMap : BaseMap<Produto>
    {
        public ProdutoMap() : base("")
        {

        }

        public override void Configure(EntityTypeBuilder<Produto> builder)
        {
            base.Configure(builder);


            builder.Property(x => x.Nome).HasColumnType("varchar(150)").IsRequired();
            builder.Property(x => x.Preco).HasColumnType("decimal(18,2)");
            builder.Property(x => x.DataCadastro).HasDefaultValue(DateTime.Now);
        }
    }
}
