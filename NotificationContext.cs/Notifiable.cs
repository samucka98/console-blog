namespace Consoleblog.NotificationContext
{
  public abstract class Notifiable
  {
    public List<Notification> Notifications { get; set; }

    public void Add(Notification notification)
    {
      Notifications.AddNotification(notification);
    }

    public void AddRange(IEnumerable<Notification> notifications)
    {
      Notifications.AddNotifications(notifications);
    }
  }
}