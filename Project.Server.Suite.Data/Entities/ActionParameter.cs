using System;
using System.Collections.Generic;

namespace Project.Server.Suite.Data.Entities;

public partial class ActionParameter
{
    public long ActionParameterId { get; set; }

    public long? ActionParameterTypeId { get; set; }

    public string? Key { get; set; }

    public int Value { get; set; }

    public virtual ActionParameterType? ActionParameterType { get; set; }

    public virtual ICollection<TaskParameter> TaskParameters { get; set; } = new List<TaskParameter>();

    public virtual ICollection<TemplateParameter> TemplateParameters { get; set; } = new List<TemplateParameter>();
}
