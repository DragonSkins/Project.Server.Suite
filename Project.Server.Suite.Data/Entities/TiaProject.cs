using System;
using System.Collections.Generic;

namespace Project.Server.Suite.Data.Entities;

public partial class TiaProject
{
    public long TiaProjectId { get; set; }

    public long ProjectServerId { get; set; }

    public long ProjectGroupId { get; set; }

    public string ProjectName { get; set; } = null!;

    public string CreatedAt { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public string ChangedAt { get; set; } = null!;

    public string ChangedBy { get; set; } = null!;

    public string ProjectType { get; set; } = null!;

    public string ProjectVersion { get; set; } = null!;

    public string? Description { get; set; }

    public int DoRevisionCheck { get; set; }

    public virtual ProjectGroup ProjectGroup { get; set; } = null!;

    public virtual ProjectServer ProjectServer { get; set; } = null!;

    public virtual ICollection<Revision> Revisions { get; set; } = new List<Revision>();

    public virtual ICollection<TaskProject> TaskProjects { get; set; } = new List<TaskProject>();

    public virtual ICollection<TemplateProject> TemplateProjects { get; set; } = new List<TemplateProject>();
}
