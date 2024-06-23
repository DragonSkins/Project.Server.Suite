using System;
using System.Collections.Generic;

namespace Project.Server.Suite.Data.Entities;

public partial class TaskSettingType
{
    public long TaskSettingTypeId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public int DefaultSelection { get; set; }

    public virtual ICollection<Setting> Settings { get; set; } = new List<Setting>();
}
