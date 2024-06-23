using Project.Server.Suite.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Server.Suite.Base
{
    public class SmtpSetting : ISmtpSetting
    {
        public int DefaultCredential { get; set; }
        public int Delivery { get; set; }
        public int DeliveryFormat { get; set; }
        public int DeliveryTimeout { get; set; }
        public string? Description { get; set; }
        public string Host { get; set; }
        public string Name { get; set; }
        public int Port { get; set; }
        public string SmtpPass { get; set; }
        public long SmtpSettingId { get; set; }
        public int SslEnabled { get; set; }
        public int Status { get; set; }
        public string User { get; set; }
    }
}
