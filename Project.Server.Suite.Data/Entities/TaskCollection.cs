using System;
using System.Collections.Generic;

namespace Project.Server.Suite.Data.Entities;

public partial class TaskCollection
{
    public long TaskCollectionId { get; set; }

    public long PssTaskId { get; set; }

    public long TemplateId { get; set; }

    public virtual PssTask PssTask { get; set; } = null!;

    public virtual Template Template { get; set; } = null!;
}
