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
            throw new System.NotImplementedException();
        }

        public Article GetArticle(string articleName)
        {
            throw new System.NotImplementedException();
        }

        public void Add(Article article)
        {
            throw new System.NotImplementedException();
        }
    }
}
