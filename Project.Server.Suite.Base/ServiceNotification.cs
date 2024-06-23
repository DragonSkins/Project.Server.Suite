using Project.Server.Suite.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Server.Suite.Base
{
    public class ServiceNotification : IServiceNotification
    {
        public string MailFrom { get; set; }
        public string MailSubject { get; set; }
        public string ServiceName { get; set; }
        public long ServiceNotificationId { get; set; }
        public ICollection<ServiceToMail> ServiceToMails { get; set; }
    }
}
