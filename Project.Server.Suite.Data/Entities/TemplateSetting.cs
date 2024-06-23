using System;
using System.Collections.Generic;

namespace Project.Server.Suite.Data.Entities;

public partial class TemplateSetting
{
    public long TemplateSettingId { get; set; }

    public long SettingId { get; set; }

    public long TemplateId { get; set; }

    public virtual Setting Setting { get; set; } = null!;

    public virtual Template Template { get; set; } = null!;
}
