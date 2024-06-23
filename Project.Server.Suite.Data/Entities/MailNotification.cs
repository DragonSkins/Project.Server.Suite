using System;
using System.Collections.Generic;

namespace Project.Server.Suite.Data.Entities;

public partial class MailNotification
{
    public long MailNotificationId { get; set; }

    public string MailName { get; set; } = null!;

    public string MailTo { get; set; } = null!;

    public int ActiveState { get; set; }

    public int LockedState { get; set; }

    public int MarkForDelete { get; set; }

    public virtual ICollection<ServiceToMail> ServiceToMails { get; set; } = new List<ServiceToMail>();
}
