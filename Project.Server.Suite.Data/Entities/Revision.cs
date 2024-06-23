using System;
using System.Collections.Generic;

namespace Project.Server.Suite.Data.Entities;

public partial class Revision
{
    public long RevisionId { get; set; }

    public long TiaProjectId { get; set; }

    public int ProjectRevision { get; set; }

    public string Author { get; set; } = null!;

    public string Notice { get; set; } = null!;

    public int SendNotification { get; set; }

    public int InputNotification { get; set; }

    public string Tested { get; set; } = null!;

    public string Modified { get; set; } = null!;

    public string LastModified { get; set; } = null!;

    public string? RevisionHash { get; set; }

    public virtual ICollection<TaskExecuteRevision> TaskExecuteRevisions { get; set; } = new List<TaskExecuteRevision>();

    public virtual TiaProject TiaProject { get; set; } = null!;
}
