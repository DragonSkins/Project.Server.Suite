using System;
using System.Collections.Generic;

namespace Project.Server.Suite.Data.Entities;

public partial class TemplateServer
{
    public long TemplateServerId { get; set; }

    public long ProjectServerId { get; set; }

    public long TemplateId { get; set; }

    public int Destination { get; set; }

    public virtual ProjectServer ProjectServer { get; set; } = null!;

    public virtual Template Template { get; set; } = null!;
}
