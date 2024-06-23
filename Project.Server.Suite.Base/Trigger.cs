using Project.Server.Suite.Base.Interfaces;

namespace Project.Server.Suite.Base
{
    public class Trigger : ITrigger
    {
        public long TriggerId { get; set; }
        public int TriggerMode { get; set; }
        public int? RevisionMode { get; set; }
        public int? ScheduleMode { get; set; }
        public string TimeSchedule { get; set; }
        public int? WeekDay { get; set; }
    }
}
