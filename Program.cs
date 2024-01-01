using Consoleblog.ContentContext;

namespace Consoleblog
{
  public class Program
  {
    static void Main()
    {
      var autor = new Author("Samuel Ibiapino", "samuel-ibiapino");
      var categoria = new Category("Backend", "backend");
      var article = new Article("API Rest com ASP.NET", "apo-rest-com-aspnet", "Bla Bla Bla...", autor, categoria);

      foreach (var author in autor.Articles)
      {
        Console.WriteLine(author.Title);
      }
    }
  }
}