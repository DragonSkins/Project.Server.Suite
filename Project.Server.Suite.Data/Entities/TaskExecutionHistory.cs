using System;
using System.Collections.Generic;

namespace Project.Server.Suite.Data.Entities;

public partial class TaskExecutionHistory
{
    public long TaskExecutionHistoryId { get; set; }

    public long? PssTaskId { get; set; }

    public string? TaskName { get; set; }

    public string? ServerName { get; set; }

    public string? ProjectName { get; set; }

    public string? ScriptName { get; set; }

    public string? ScriptConfiguration { get; set; }

    public int? ExecutionStatus { get; set; }

    public string? ExecutionProtocol { get; set; }

    public string? ExecutionPlanned { get; set; }

    public string? ExecutionStarted { get; set; }

    public string? ExecutionFinished { get; set; }

    public string? Guid { get; set; }

    public string? Description { get; set; }

    public string? TriggerMode { get; set; }

    public int? Status { get; set; }

    public virtual PssTask? PssTask { get; set; }
}
