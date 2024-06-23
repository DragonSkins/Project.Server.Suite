namespace Project.Server.Suite.Base.Interfaces
{
    public interface ITrigger
    {
        long TriggerId { get; set; }
        int TriggerMode { get; set; }
        int? RevisionMode { get; set; }
        int? ScheduleMode { get; set; }
        string TimeSchedule { get; set; }
        int? WeekDay { get; set; }
    }
}
