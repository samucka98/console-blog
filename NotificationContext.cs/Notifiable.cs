namespace Consoleblog.NotificationContext
{
  public abstract class Notifiable
  {
    public List<Notification> Notifications { get; set; }

    public void AddNotification(Notification notification)
    {
      Notifications.Add(notification);
    }

    public void AddNotifications(IEnumerable<Notification> notifications)
    {
      Notifications.AddRange(notifications);
    }
  }
}