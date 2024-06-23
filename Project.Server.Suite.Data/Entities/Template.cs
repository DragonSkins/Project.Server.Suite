using System;
using System.Collections.Generic;

namespace Project.Server.Suite.Data.Entities;

public partial class Template
{
    public long TemplateId { get; set; }

    public long TriggerId { get; set; }

    public long ActionScriptId { get; set; }

    public int Status { get; set; }

    public int Execution { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string CreatedAt { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public string ChangedAt { get; set; } = null!;

    public string ChangedBy { get; set; } = null!;

    public virtual ActionScript ActionScript { get; set; } = null!;

    public virtual ICollection<PssTask> PssTasks { get; set; } = new List<PssTask>();

    public virtual ICollection<TaskCollection> TaskCollections { get; set; } = new List<TaskCollection>();

    public virtual ICollection<TemplateParameter> TemplateParameters { get; set; } = new List<TemplateParameter>();

    public virtual ICollection<TemplateProject> TemplateProjects { get; set; } = new List<TemplateProject>();

    public virtual ICollection<TemplateServer> TemplateServers { get; set; } = new List<TemplateServer>();

    public virtual ICollection<TemplateSetting> TemplateSettings { get; set; } = new List<TemplateSetting>();

    public virtual Trigger Trigger { get; set; } = null!;
}
