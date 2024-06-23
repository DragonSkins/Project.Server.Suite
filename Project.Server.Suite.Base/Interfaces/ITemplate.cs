using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Server.Suite.Base.Interfaces
{
    public interface ITemplate
    {
        long TemplateId { get; set; }
        long Status { get; set; }
        long Execution { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        DateTime CreatedAt { get; set; }
        string CreatedBy { get; set; }
        DateTime ChangedAt { get; set; }
        string ChangedBy { get; set; }
        Trigger? Trigger {  get; set; }
        ActionScript ActionScript { get; set; }
    }
}
