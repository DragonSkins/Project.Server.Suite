using System;
using System.Collections.Generic;

namespace Project.Server.Suite.Data.Entities;

public partial class TaskProject
{
    public long TaskProjectId { get; set; }

    public long TiaProjectId { get; set; }

    public long PssTaskId { get; set; }

    public int Destination { get; set; }

    public virtual PssTask PssTask { get; set; } = null!;

    public virtual TiaProject TiaProject { get; set; } = null!;
}
