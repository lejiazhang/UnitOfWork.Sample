using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UnitOfWork.Sample.Domain.Models;
using UnitOfWork.Sample.Domain.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UnitOfWork.Sample.WebApi.Controllers
{
    [Route("api/Articles")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        private readonly IArticleService _articles;

        public ArticlesController(IArticleService articles)
        {
            _articles = articles;
        }

        [HttpGet]
        public ActionResult<List<Article>> GetAllArticles()
        {
            List<Article> allArtilces = _articles.GetAllArticles();
            return allArtilces;
        }

        [HttpPost]
        public void CreateArticle([FromBody] CreateArticle article)
        {
            _articles.CreateArticle(article);
        }
    }
}
