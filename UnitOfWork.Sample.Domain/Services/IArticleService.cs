using System.Collections.Generic;
using UnitOfWork.Sample.Domain.Models;

namespace UnitOfWork.Sample.Domain.Services
{
    public interface IArticleService
    {
        List<Article> GetAllArticles();

        void CreateArticle(CreateArticle article);
    }
}
