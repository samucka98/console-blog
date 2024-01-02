using Consoleblog.NotificationContext;

namespace Consoleblog.ContentContext
{
  public class Article : Content
  {
    public delegate void ArticleCreatedHandler(Author autor, Article article);
    public event ArticleCreatedHandler? NewArticleCreated;

    public Article(string title, string slug, string contentText, Author autor, Category categoria)
    : base(title, slug)
    {
      ContentText = contentText;
      Autor = autor;
      Categoria = categoria;

      if (autor == null)
      {
        AddNotification(new Notification("Autor", "O autor nao esta presente!"));
      }
      else
      {
        new SetService().SetServiceAuthor(this, new AuthorService());
        Signature();
      }


      if (categoria == null)
        AddNotification(new Notification("Categoria", "A categoria nao esta presente!"));
    }

    public string ContentText { get; set; }
    public Author Autor { get; set; }
    public Category Categoria { get; set; }

    public void Signature()
    {
      NewArticleCreated?.Invoke(Autor, this);
    }

    public void CreateNewArticle()
    {
      Console.Clear();
      Console.WriteLine("");
    }
  }
}