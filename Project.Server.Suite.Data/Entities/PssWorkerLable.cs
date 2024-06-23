using System;
using System.Collections.Generic;

namespace Project.Server.Suite.Data.Entities;

public partial class PssWorkerLable
{
    public long PssWorkerLableId { get; set; }

    public string LableName { get; set; } = null!;

    public string? Description { get; set; }
}
