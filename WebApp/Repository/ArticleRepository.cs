using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp
{
    public class ArticleRepository
    {
        private List<Articles> articles = new List<Articles>
        {
            new Articles
            {
                Id = 1,
                Title = "What is Lorem Ipsum?",
                Author= "Gaurav Gahlot",
                PublishedOn = new DateTime(2019, 01, 20),
                Content = "Lorem Ipsum is simply dummy text of the printing " +
                          "and typesetting industry."
            },
        };

        public List<Articles> GetArticles()
        {
            return articles;
        }
    }
}
