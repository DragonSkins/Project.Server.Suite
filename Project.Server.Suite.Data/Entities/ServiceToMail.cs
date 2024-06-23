using System;
using System.Collections.Generic;

namespace Project.Server.Suite.Data.Entities;

public partial class ServiceToMail
{
    public long ServiceToMailId { get; set; }

    public long ServiceNotificationId { get; set; }

    public long MailNotificationId { get; set; }

    public virtual MailNotification MailNotification { get; set; } = null!;

    public virtual ServiceNotification ServiceNotification { get; set; } = null!;
}
