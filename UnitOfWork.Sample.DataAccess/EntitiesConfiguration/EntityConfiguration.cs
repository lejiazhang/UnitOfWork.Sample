namespace UnitOfWork.Sample.DataAccess.EntitiesConfiguration
{
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal abstract class EntityConfiguration<TEntity> where TEntity : class
    {
        public abstract void Configure(EntityTypeBuilder<TEntity> builder);
    }
}
