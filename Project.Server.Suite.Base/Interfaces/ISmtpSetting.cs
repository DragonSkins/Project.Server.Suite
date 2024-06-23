namespace Project.Server.Suite.Base.Interfaces
{
    public interface ISmtpSetting
    {
        int DefaultCredential { get; set; }
        int Delivery { get; set; }
        int DeliveryFormat { get; set; }
        int DeliveryTimeout { get; set; }
        string? Description { get; set; }
        string Host { get; set; }
        string Name { get; set; }
        int Port { get; set; }
        string SmtpPass { get; set; }
        long SmtpSettingId { get; set; }
        int SslEnabled { get; set; }
        int Status { get; set; }
        string User { get; set; }
    }
}