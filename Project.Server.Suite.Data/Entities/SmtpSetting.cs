using System;
using System.Collections.Generic;

namespace Project.Server.Suite.Data.Entities;

public partial class SmtpSetting
{
    public long SmtpSettingId { get; set; }

    public string Name { get; set; } = null!;

    public string Host { get; set; } = null!;

    public int Port { get; set; }

    public int Status { get; set; }

    public string User { get; set; } = null!;

    public string SmtpPass { get; set; } = null!;

    public string? Description { get; set; }

    public int SslEnabled { get; set; }

    public int Delivery { get; set; }

    public int DefaultCredential { get; set; }

    public int DeliveryFormat { get; set; }

    public int DeliveryTimeout { get; set; }
}
