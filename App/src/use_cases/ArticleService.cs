namespace UseCases
{
    using domain.entities;
    using System.Collections.Generic;


    public class ArticleService
    {
        private List<Article> articles = new List<Article>();
        private int nextId = 1;

        public List<Article> GetAll() => articles;

        public Article Add(Article article)
        {
            article.Id = nextId++;
            articles.Add(article);
            return article;
        }

        public Article Update(Article article)
        {
            var existingArticle = articles.Find(a => a.Id == article.Id);
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
            var article = articles.Find(a => a.Id == id);
            if (article != null)
            {
                articles.Remove(article);
                return true;
            }
            return false;
        }
    }
}
