using Project.Server.Suite.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Server.Suite.Base
{
    public class PssTask : IPssTask
    {
        public ActionScript? ActionScript { get; set; }
        public long? ActionScriptId { get; set; }
        public string ChangedAt { get; set; }
        public string ChangedBy { get; set; }
        public string? CheckInMode { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string? Description { get; set; }
        public int? Execution { get; set; }
        public string? ExecutionFinished { get; set; }
        public string? ExecutionStarted { get; set; }
        public string? GroupName { get; set; }
        public string Guid { get; set; }
        public string Name { get; set; }
        public string Planned { get; set; }
        public string? ProjectName { get; set; }
        public long PssTaskId { get; set; }
        public string? RevisionOption { get; set; }
        public string? ScheduleMode { get; set; }
        public string? ServerName { get; set; }
        public string? ServerUrl { get; set; }
        public int Status { get; set; }
        public ICollection<TaskCollection> TaskCollections { get; set; }
        public ICollection<TaskExecuteRevision> TaskExecuteRevisions { get; set; }
        public ICollection<TaskExecutionHistory> TaskExecutionHistories { get; set; }
        public ICollection<TaskParameter> TaskParameters { get; set; }
        public ICollection<TaskProject> TaskProjects { get; set; }
        public ICollection<TaskServer> TaskServers { get; set; }
        public ICollection<TaskSetting> TaskSettings { get; set; }
        public Template Template { get; set; }
        public long TemplateId { get; set; }
        public string TimeSchedule { get; set; }
        public string? TriggerMode { get; set; }
        public string? Weekday { get; set; }
    }
}
