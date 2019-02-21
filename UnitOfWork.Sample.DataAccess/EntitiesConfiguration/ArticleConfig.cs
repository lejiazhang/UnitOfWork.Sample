namespace UnitOfWork.Sample.DataAccess.EntitiesConfiguration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using UnitOfWork.Sample.DataAccess.Entities;

    internal class ArticleConfig : EntityConfiguration<Article>
    {
        public override void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.ToTable("Article", Schema.Dbo);
            builder.HasKey(x => x.Id);
        }
    }
}
