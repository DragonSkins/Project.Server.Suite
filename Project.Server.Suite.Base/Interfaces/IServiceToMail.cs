namespace Project.Server.Suite.Base.Interfaces
{
    public interface IServiceToMail
    {
        MailNotification MailNotification { get; set; }
        long MailNotificationId { get; set; }
        ServiceNotification ServiceNotification { get; set; }
        long ServiceNotificationId { get; set; }
        long ServiceToMailId { get; set; }
    }
}