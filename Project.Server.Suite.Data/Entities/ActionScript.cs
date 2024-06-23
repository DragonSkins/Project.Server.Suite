using System;
using System.Collections.Generic;

namespace Project.Server.Suite.Data.Entities;

public partial class ActionScript
{
    public long ActionScriptId { get; set; }

    public string ScriptName { get; set; } = null!;

    public string? Extension { get; set; }

    public string Path { get; set; } = null!;

    public string? Description { get; set; }

    public string CreatedAt { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public string ChangedAt { get; set; } = null!;

    public string ChangedBy { get; set; } = null!;

    public virtual ICollection<PssTask> PssTasks { get; set; } = new List<PssTask>();

    public virtual ICollection<Template> Templates { get; set; } = new List<Template>();
}
