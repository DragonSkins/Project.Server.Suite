using System;
using System.Collections.Generic;

namespace Project.Server.Suite.Data.Entities;

public partial class TemplateParameter
{
    public long TemplateParameterId { get; set; }

    public long ActionParameterId { get; set; }

    public long TemplateId { get; set; }

    public string? ParameterValue { get; set; }

    public virtual ActionParameter ActionParameter { get; set; } = null!;

    public virtual Template Template { get; set; } = null!;
}
