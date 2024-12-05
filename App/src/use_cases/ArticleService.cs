namespace UseCases
{
    using System.ComponentModel;
    using System.Linq;
    using App;
    using domain.entities;

    public class ArticleService
    {
        public BindingList<Article> articles = new BindingList<Article>();
        private int nextId = 1;

        public BindingList<Article> GetAll() => articles;

        public Article Add(Article article)
        {
            article.Id = nextId++;
            articles.Add(article);
            return article;
        }

        public Article Update(Article article)
        {
            var existingArticle = articles.First(a => a.Id == article.Id);
            if (existingArticle != null)
            {
                existingArticle.Name = article.Name;
                existingArticle.Price = article.Price;
                existingArticle.Quantity = article.Quantity;
            }
            return existingArticle;
        }

        public bool Delete(int id)
        {
            var article = articles.First(a => a.Id == id);
            if (article != null)
            {
                articles.Remove(article);
                return true;
            }
            return false;
        }

        public void LoadArticles()
        {
            articles = JsonHelper.LoadArticles();
            nextId = articles.Count > 0 ? articles.Max(a => a.Id) + 1 : 1;
        }

        public void SaveArticles()
        {
            JsonHelper.SaveArticles(articles);
        }
    }
}
