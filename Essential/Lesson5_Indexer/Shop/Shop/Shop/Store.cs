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
            return ();
        }

        public void Add(Article article)
        {
            _articls.Add(article);
        }
    }
}
