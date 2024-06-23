using System;
using System.Collections.Generic;

namespace Project.Server.Suite.Data.Entities;

public partial class ProjectServer
{
    public long ProjectServerId { get; set; }

    public string ServerUrl { get; set; } = null!;

    public string ServerName { get; set; } = null!;

    public string HostName { get; set; } = null!;

    public int PortNumber { get; set; }

    public int Status { get; set; }

    public string? Description { get; set; }

    public int DoRevisionCheck { get; set; }

    public virtual ICollection<ProjectGroup> ProjectGroups { get; set; } = new List<ProjectGroup>();

    public virtual ICollection<TemplateServer> TemplateServers { get; set; } = new List<TemplateServer>();

    public virtual ICollection<TaskServer> TaskServers { get; set; } = new List<TaskServer>();

    public virtual ICollection<TiaProject> TiaProjects { get; set; } = new List<TiaProject>();
}
