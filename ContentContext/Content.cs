using Consoleblog.SharedContext;

namespace Consoleblog.ContentContext
{
  public abstract class Content : Base
  {
    public Content(string title, string slug)
    {
      Title = title;
      Slug = slug;
    }
    public string Title { get; set; }
    public string Slug { get; set; }
  }
}