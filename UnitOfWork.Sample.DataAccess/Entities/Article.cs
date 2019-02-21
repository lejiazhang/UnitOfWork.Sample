namespace UnitOfWork.Sample.DataAccess.Entities
{
    using System;

    public class Article
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
