using System;
using System.Collections.Generic;

namespace Project.Server.Suite.Data.Entities;

public partial class TaskServer
{
    public long TaskServerId { get; set; }

    public long ProjectServerId { get; set; }

    public long PssTaskId { get; set; }

    public int Destination { get; set; }

    public virtual ProjectServer ProjectServer { get; set; } = null!;

    public virtual PssTask PssTask { get; set; } = null!;
}
