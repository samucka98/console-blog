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

      if (autor == null)
        throw new Exception("Para criar um novo artigo é necessário informar um autor!");

      if (categoria == null)
        throw new Exception("para cria um novo artigo é necessário informar uma categoria!");
    }

    public string ContentText { get; set; }
    public Author Autor { get; set; }
    public Category Categoria { get; set; }
  }
}