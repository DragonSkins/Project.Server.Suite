using System;
using System.Collections.Generic;

namespace Project.Server.Suite.Data.Entities;

public partial class WorkerLable
{
    public long WorkerLableId { get; set; }

    public string LableName { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<WorkerAssignedLable> WorkerAssignedLables { get; set; } = new List<WorkerAssignedLable>();
}
