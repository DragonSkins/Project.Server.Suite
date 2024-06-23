using Project.Server.Suite.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Server.Suite.Base
{
    public class MailNotification : IMailNotification
    {
        public int ActiveState { get; set; }
        public int LockedState { get; set; }
        public string MailName { get; set; }
        public long MailNotificationId { get; set; }
        public string MailTo { get; set; }
        public int MarkForDelete { get; set; }
        public ICollection<ServiceToMail> ServiceToMails { get; set; }
    }
}
