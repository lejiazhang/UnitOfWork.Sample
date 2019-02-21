using System;
using System.Collections.Generic;
using System.Text;

namespace UnitOfWork.Sample.Domain.Models
{
    public abstract class ArticleBase
    {
        public string Title { get; set; }

        public string Content { get; set; }
    }
    public class Article : ArticleBase
    {
        public int Id { get; set; }

        public DateTime CreatedOn { get; set; }

    }

    public class CreateArticle : ArticleBase
    {

    }
}
