namespace UnitOfWork.Sample.Services.Implementation
{
    using System;
    using System.Collections.Generic;
    using UnitOfWork.Core;
    using UnitOfWork.Sample.DataAccess;
    using UnitOfWork.Sample.Domain.Models;
    using UnitOfWork.Sample.Domain.Services;
    using System.Linq;

    public class ArticleService : ServiceBase, IArticleService
    {
        public ArticleService(IUnitOfWork<IDataProvider> uow) : base(uow)
        {
        }
        public void CreateArticle(CreateArticle article)
        {
            if (article == null) throw new ArgumentException("article");
            if (string.IsNullOrEmpty(article.Title)) throw new Exception("Title cannot be empty.");

            DataAccess.Entities.Article dbArticle = new DataAccess.Entities.Article()
            {
                CreatedOn = DateTime.UtcNow,
                Title = article.Title,
                Content = article.Content
            };

            _uow.DataProvider.Articles.Add(dbArticle);
        }

        public List<Article> GetAllArticles()
        {
            return _uow.DataProvider.Articles.ToList().Select(x => new Article {
                Id = x.Id,
                Content = x.Content,
                CreatedOn = x.CreatedOn,
                Title = x.Title
            }).ToList();
        }
    }
}
