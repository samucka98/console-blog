namespace Consoleblog.ContentContext
{
  public class SetService
  {
    public void SerServiceAuthor(Article article, AuthorService service)
    {
      article.NewArticleCreated += service.SignatureArticle;
    }
  }
}