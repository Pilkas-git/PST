using System;
using System.Collections.Generic;
using System.Text;

namespace PST
{
    public class ArticleCollection
    {
        public List<Article> Articles { get; set; }
    }

    public class Article
    {
        public Source Source { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public DateTime PublishedAt { get; set; }
        public string Content { get; set; }
    }

}
