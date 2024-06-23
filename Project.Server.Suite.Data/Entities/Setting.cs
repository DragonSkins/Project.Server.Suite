using System;
using System.Collections.Generic;

namespace Project.Server.Suite.Data.Entities;

public partial class Setting
{
    public long SettingId { get; set; }

    public long? TaskSettingTypeId { get; set; }

    public int Value { get; set; }

    public virtual TaskSettingType? TaskSettingType { get; set; }

    public virtual ICollection<TaskSetting> TaskSettings { get; set; } = new List<TaskSetting>();

    public virtual ICollection<TemplateSetting> TemplateSettings { get; set; } = new List<TemplateSetting>();
}
