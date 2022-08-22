using Estudo_FluentAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Estudo_FluentAPI.Mapping
{
    public class BaseMap<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : Base
    {
        private readonly string _tableName;

        public BaseMap(string TableName)
        {
            _tableName = TableName;
        }
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            if (!string.IsNullOrEmpty(_tableName))
                builder.ToTable(_tableName);

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
        }
    }
}
