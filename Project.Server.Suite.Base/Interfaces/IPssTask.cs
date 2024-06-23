
namespace Project.Server.Suite.Base.Interfaces
{
    public interface IPssTask
    {
        ActionScript? ActionScript { get; set; }
        long? ActionScriptId { get; set; }
        string ChangedAt { get; set; }
        string ChangedBy { get; set; }
        string? CheckInMode { get; set; }
        string CreatedAt { get; set; }
        string CreatedBy { get; set; }
        string? Description { get; set; }
        int? Execution { get; set; }
        string? ExecutionFinished { get; set; }
        string? ExecutionStarted { get; set; }
        string? GroupName { get; set; }
        string Guid { get; set; }
        string Name { get; set; }
        string Planned { get; set; }
        string? ProjectName { get; set; }
        long PssTaskId { get; set; }
        string? RevisionOption { get; set; }
        string? ScheduleMode { get; set; }
        string? ServerName { get; set; }
        string? ServerUrl { get; set; }
        int Status { get; set; }
        ICollection<TaskCollection> TaskCollections { get; set; }
        ICollection<TaskExecuteRevision> TaskExecuteRevisions { get; set; }
        ICollection<TaskExecutionHistory> TaskExecutionHistories { get; set; }
        ICollection<TaskParameter> TaskParameters { get; set; }
        ICollection<TaskProject> TaskProjects { get; set; }
        ICollection<TaskServer> TaskServers { get; set; }
        ICollection<TaskSetting> TaskSettings { get; set; }
        Template Template { get; set; }
        long TemplateId { get; set; }
        string TimeSchedule { get; set; }
        string? TriggerMode { get; set; }
        string? Weekday { get; set; }
    }
}