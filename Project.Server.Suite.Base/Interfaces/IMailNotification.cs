
namespace Project.Server.Suite.Base.Interfaces
{
    public interface IMailNotification
    {
        int ActiveState { get; set; }
        int LockedState { get; set; }
        string MailName { get; set; }
        long MailNotificationId { get; set; }
        string MailTo { get; set; }
        int MarkForDelete { get; set; }
        ICollection<ServiceToMail> ServiceToMails { get; set; }
    }
}