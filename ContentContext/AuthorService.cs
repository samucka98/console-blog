namespace Consoleblog.ContentContext
{
  public class AuthorService
  {
    public void SignatureArticle(Author autor, Article article)
    {
      autor.Articles?.Add(article);
      Console.WriteLine($"O autor: {autor.Title} assinou o artigo: {article.Title}");
    }
  }
}