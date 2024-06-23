using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Project.Server.Suite.Data.Entities;

public partial class WorkerAssignedLable
{
    public long WorkerAssignedLableId { get; set; }

    public long WorkerId { get; set; }

    public long WorkerLableId { get; set; }

    public virtual Worker Worker { get; set; } = null!;

    public virtual WorkerLable WorkerLable { get; set; } = null!;
}
