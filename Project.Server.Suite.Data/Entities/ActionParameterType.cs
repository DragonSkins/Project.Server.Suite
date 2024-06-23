using System;
using System.Collections.Generic;

namespace Project.Server.Suite.Data.Entities;

public partial class ActionParameterType
{
    public long ActionParameterTypeId { get; set; }

    public int ParameterType { get; set; }

    public int Visibility { get; set; }

    public string Key { get; set; } = null!;

    public string? KeyCmd { get; set; }

    public string KeyAlias { get; set; } = null!;

    public string ToolTip { get; set; } = null!;

    public virtual ICollection<ActionParameter> ActionParameters { get; set; } = new List<ActionParameter>();
}
