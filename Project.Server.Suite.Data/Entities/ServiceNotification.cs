using System;
using System.Collections.Generic;

namespace Project.Server.Suite.Data.Entities;

public partial class ServiceNotification
{
    public long ServiceNotificationId { get; set; }

    public string ServiceName { get; set; } = null!;

    public string MailSubject { get; set; } = null!;

    public string MailFrom { get; set; } = null!;

    public virtual ICollection<ServiceToMail> ServiceToMails { get; set; } = new List<ServiceToMail>();
}
