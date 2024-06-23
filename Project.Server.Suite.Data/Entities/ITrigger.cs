
namespace Project.Server.Suite.Data.Entities
{
    public interface ITrigger
    {
        int? RevisionMode { get; set; }
        int? ScheduleMode { get; set; }
        ICollection<Template> Templates { get; set; }
        string? TimeSchedule { get; set; }
        long TriggerId { get; set; }
        int TriggerMode { get; set; }
        int? WeekDay { get; set; }
    }
}