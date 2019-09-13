using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class ArticlesViewModel
    {
        public List<Articles> articles { get; set; }
        public ArticlesViewModel()
        {
            articles = new List<Articles>();
        }
    }

    public class Articles
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime PublishedOn { get; set; }
        public string Content { get; set; }
    }
}
