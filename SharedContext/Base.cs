using Consoleblog.NotificationContext;

namespace Consoleblog.SharedContext
{
  public abstract class Base : Notifiable
  {
    public Base()
    {
      Id = Guid.NewGuid();
    }

    public Guid Id { get; set; }
  }
}