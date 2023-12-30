namespace Consoleblog.ContentContext
{
  public abstract class Content
  {
    public Content(string title, string slug)
    {
      Id = Guid.NewGuid();
      Title = title;
      Slug = slug;
    }

    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Slug { get; set; }
  }
}