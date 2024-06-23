using System;
using System.Collections.Generic;

namespace Project.Server.Suite.Data.Entities;

public partial class PssTask
{
    public long PssTaskId { get; set; }

    public long TemplateId { get; set; }

    public long ActionScriptId { get; set; }

    public int Status { get; set; }

    public int? Execution { get; set; }

    public string Name { get; set; } = null!;

    public string? ServerName { get; set; }

    public string? GroupName { get; set; }

    public string? ProjectName { get; set; }

    public string? ServerUrl { get; set; }

    public string? Description { get; set; }

    public string? TriggerMode { get; set; }

    public string? CheckInMode { get; set; }

    public string? RevisionOption { get; set; }

    public string? ScheduleMode { get; set; }

    public string TimeSchedule { get; set; } = null!;

    public string? Weekday { get; set; }

    public string CreatedAt { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public string ChangedAt { get; set; } = null!;

    public string ChangedBy { get; set; } = null!;

    public string Planned { get; set; } = null!;

    public string? ExecutionStarted { get; set; }

    public string? ExecutionFinished { get; set; }

    public string Guid { get; set; } = null!;

    public virtual ActionScript? ActionScript { get; set; }

    public virtual ICollection<TaskCollection> TaskCollections { get; set; } = new List<TaskCollection>();

    public virtual ICollection<TaskExecuteRevision> TaskExecuteRevisions { get; set; } = new List<TaskExecuteRevision>();

    public virtual ICollection<TaskExecutionHistory> TaskExecutionHistories { get; set; } = new List<TaskExecutionHistory>();

    public virtual ICollection<TaskParameter> TaskParameters { get; set; } = new List<TaskParameter>();

    public virtual ICollection<TaskProject> TaskProjects { get; set; } = new List<TaskProject>();

    public virtual ICollection<TaskServer> TaskServers { get; set; } = new List<TaskServer>();

    public virtual ICollection<TaskSetting> TaskSettings { get; set; } = new List<TaskSetting>();

    public virtual Template Template { get; set; } = null!;
}
