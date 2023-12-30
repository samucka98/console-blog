using Consoleblog.ContentContext;

namespace Consoleblog
{
  public class Program
  {
    static void Main()
    {
      var categoria = new Category("Backend", "backend");
      var autor = new Author("Samuel Ibiapino", "samuel-ibiapino");
      var article = new Article("Api completa usando ASP.NET", "api-completa-aspnet", "Bla bla bla...", autor, categoria);
      autor.Articles.Add(article);

      Console.WriteLine($"ID: {article.Id}");
      Console.WriteLine($"Titulo: {article.Title}");
      Console.WriteLine($"Escrito por: {article.Autor.Title}");
      Console.WriteLine($"Categoria: {article.Categoria.Title}");
      Console.WriteLine($"Leia aqui o conteudo: {article.ContentText}");
    }
  }
}