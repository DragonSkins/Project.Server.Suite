using System;
using System.Collections.Generic;

namespace Project.Server.Suite.Data.Entities;

public partial class Worker
{
    public long WorkerId { get; set; }

    public string WorkerName { get; set; } = null!;

    public string? Description { get; set; }

    public int Status { get; set; }

    public string KeepAlive { get; set; } = null!;

    public virtual ICollection<WorkerAssignedLable> WorkerAssignedLables { get; set; } = new List<WorkerAssignedLable>();
}
