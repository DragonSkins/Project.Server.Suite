using Project.Server.Suite.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Server.Suite.Base
{
    public class Template : ITemplate
    {
        public long TemplateId { get; set; }
        public long Status { get; set; }
        public long Execution { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ChangedAt { get; set; }
        public string ChangedBy { get; set; }
        public Trigger Trigger { get; set; }
        public ActionScript ActionScript { get; set; }
    }
}
