using Project.Server.Suite.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Server.Suite.Base
{
    public class TemplateProject : ITemplateProject
    {
        public int Destination { get; set; }
        public Template Template { get; set; }
        public long TemplateId { get; set; }
        public long TemplateProjectId { get; set; }
        public TiaProject TiaProject { get; set; }
        public long TiaProjectId { get; set; }
    }
}
