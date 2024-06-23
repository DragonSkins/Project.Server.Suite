using System;
using System.Collections.Generic;

namespace Project.Server.Suite.Data.Entities;

public partial class ProjectGroup
{
    public long ProjectGroupId { get; set; }

    public long ProjectServerId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public int DoRevisionCheck { get; set; }

    public virtual ProjectServer ProjectServer { get; set; } = null!;

    public virtual ICollection<TiaProject> TiaProjects { get; set; } = new List<TiaProject>();
}
