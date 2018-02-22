using System.Collections.Generic;

namespace Shop
{
    class Store
    {
        private List<Article> _articls;

        public Store()
        {
            _articls = new List<Article>();
        }

        public Article GetArticle(int index)
        {
            return _articls[index];
        }

        public Article GetArticle(string articleName)
        {
            Article article = null;
            foreach (var a in _articls)
            {
                if (a.Name == articleName)
                {
                    article = a;
                }
            }

            return article;
        }

        public void Add(Article article)
        {
            _articls.Add(article);
        }
    }
}
