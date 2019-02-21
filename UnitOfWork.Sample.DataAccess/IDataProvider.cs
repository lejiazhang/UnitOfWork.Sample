namespace UnitOfWork.Sample.DataAccess
{
    using Microsoft.EntityFrameworkCore;
    using UnitOfWork.Sample.DataAccess.Entities;

    public interface IDataProvider
    {
        DbSet<Article> Articles { get; }
    }

    public class DataProvider : IDataProvider
    {
        public DbSet<Article> Articles { get; private set; }
        public DataProvider(AppDbContext dbContext)
        {
            Articles = dbContext.Articles;
        }
    }
}
