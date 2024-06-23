using Project.Server.Suite.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Server.Suite.Base
{
    public class ServiceToMail : IServiceToMail
    {
        public MailNotification MailNotification { get; set; }
        public long MailNotificationId { get; set; }
        public ServiceNotification ServiceNotification { get; set; }
        public long ServiceNotificationId { get; set; }
        public long ServiceToMailId { get; set; }
    }
}
