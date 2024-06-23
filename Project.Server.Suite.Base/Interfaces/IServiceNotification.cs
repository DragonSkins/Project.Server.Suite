
namespace Project.Server.Suite.Base.Interfaces
{
    public interface IServiceNotification
    {
        string MailFrom { get; set; }
        string MailSubject { get; set; }
        string ServiceName { get; set; }
        long ServiceNotificationId { get; set; }
        ICollection<ServiceToMail> ServiceToMails { get; set; }
    }
}