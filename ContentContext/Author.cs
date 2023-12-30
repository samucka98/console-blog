namespace Consoleblog.ContentContext
{
  public class Author : Content
  {
    public Author(string title, string slug)
    : base(title, slug)
    {
      Articles = new List<Article>();
    }
    public IList<Article> Articles { get; set; }
  }
}