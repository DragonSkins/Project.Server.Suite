using System;
using System.Collections.Generic;

namespace Project.Server.Suite.Data.Entities;

public partial class TaskParameter
{
    public long TaskParameterId { get; set; }

    public long ActionParameterId { get; set; }

    public long PssTaskId { get; set; }

    public string? ParameterValue { get; set; }

    public virtual ActionParameter ActionParameter { get; set; } = null!;

    public virtual PssTask PssTask { get; set; } = null!;
}
