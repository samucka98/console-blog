namespace Consoleblog.NotificationContext
{
  public sealed class Notification
  {

    public Notification()
    {
      Property = "";
      Message = "";
    }

    public Notification(string property, string message)
    {
      Property = property;
      Message = message;
    }

    public string Property { get; set; }
    public string Message { get; set; }
  }
}