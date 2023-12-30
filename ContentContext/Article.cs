namespace Consoleblog.ContentContext
{
  public class Article : Content
  {
    public Article(string title, string slug, string contentText, Author autor, Category categoria)
    : base(title, slug)
    {
      ContentText = contentText;
      Autor = autor;
      Categoria = categoria;
    }
    public string ContentText { get; set; }
    public Author Autor { get; set; }
    public Category Categoria { get; set; }
  }
}