namespace UnitOfWork.Sample.DataAccess.Extensions
{
    using Microsoft.EntityFrameworkCore;
    using UnitOfWork.Sample.DataAccess.EntitiesConfiguration;
    internal static class ModelBuilderExtensions
    {
        public static void AddConfiguration<TEntity> (this ModelBuilder modelBuilder, EntityConfiguration<TEntity> entityConfiguration) where TEntity : class
        {
            modelBuilder.Entity<TEntity>(entityConfiguration.Configure);
        }
    }
}
