using System;
using System.Collections.Generic;

namespace Project.Server.Suite.Data.Entities;

public partial class Trigger
{
    public long TriggerId { get; set; }

    public int TriggerMode { get; set; }

    public int? RevisionMode { get; set; }

    public int? ScheduleMode { get; set; }

    public string? TimeSchedule { get; set; }

    public int? WeekDay { get; set; }

    public virtual ICollection<Template> Templates { get; set; } = new List<Template>();
}
