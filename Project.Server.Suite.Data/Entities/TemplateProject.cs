using System;
using System.Collections.Generic;

namespace Project.Server.Suite.Data.Entities;

public partial class TemplateProject
{
    public long TemplateProjectId { get; set; }

    public long TiaProjectId { get; set; }

    public long TemplateId { get; set; }

    public int Destination { get; set; }

    public virtual Template Template { get; set; } = null!;

    public virtual TiaProject TiaProject { get; set; } = null!;
}
