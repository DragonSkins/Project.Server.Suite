using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Server.Suite.Base.Interfaces
{
    public interface IActionScript
    {
        long ActionScriptId { get; set; }
        string Name { get; set; }
        string Extension { get; set; }
        string Description { get; set; }
        DateTime CreatedAt { get; set; }
        string CreatedBy { get; set; }
        DateTime ChangedAt { get; set; }
        string ChangedBy { get; set; }
        string Version { get; set; }
    }
}
