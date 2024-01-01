using Consoleblog.ContentContext;

namespace Consoleblog
{
  public class Program
  {
    static void Main()
    {
      var autor = new Author("Samuel Ibiapino", "samuel-ibiapino");
      var categoria = new Category("Backend", "backend");
      var Article = new Article("API Rest com ASP.NET", "apo-rest-com-aspnet", "Bla Bla Bla...", autor, categoria);
    }
  }
}