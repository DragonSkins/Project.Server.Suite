using System;
using System.Collections.Generic;

namespace Project.Server.Suite.Data.Entities;

public partial class TaskSetting
{
    public long TaskSettingId { get; set; }

    public long SettingId { get; set; }

    public long PssTaskId { get; set; }

    public virtual PssTask PssTask { get; set; } = null!;

    public virtual Setting Setting { get; set; } = null!;
}
