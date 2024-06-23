namespace Project.Server.Suite.Base.Interfaces
{
    public interface ITaskExecutionHistory
    {
        string? Description { get; set; }
        string? ExecutionFinished { get; set; }
        string? ExecutionPlanned { get; set; }
        string? ExecutionProtocol { get; set; }
        string? ExecutionStarted { get; set; }
        int? ExecutionStatus { get; set; }
        string? Guid { get; set; }
        string? ProjectName { get; set; }
        PssTask? PssTask { get; set; }
        long? PssTaskId { get; set; }
        string? ScriptConfiguration { get; set; }
        string? ScriptName { get; set; }
        string? ServerName { get; set; }
        int? Status { get; set; }
        long TaskExecutionHistoryId { get; set; }
        string? TaskName { get; set; }
        string? TriggerMode { get; set; }
    }
}