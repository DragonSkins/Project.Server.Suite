using System;
using System.Collections.Generic;

namespace Project.Server.Suite.Data.Entities;

public partial class TaskExecuteRevision
{
    public long TaskExecuteRevisionId { get; set; }

    public long? PssTaskId { get; set; }

    public long? RevisionId { get; set; }

    public int Status { get; set; }

    public virtual PssTask? PssTask { get; set; }

    public virtual Revision? Revision { get; set; }
}
