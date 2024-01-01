namespace Consoleblog.ContentContext
{
  public class SetService
  {
    public void SetServiceAuthor(Article article, AuthorService service)
    {
      article.NewArticleCreated += service.SignatureArticle;
    }
  }
}