using Project.Server.Suite.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Server.Suite.Base
{
    public class TemplateServer : ITemplateServer
    {
        public int Destination { get; set; }
        public ProjectServer ProjectServer { get; set; }
        public long ProjectServerId { get; set; }
        //public Template Template { get; set; }
        public long TemplateId { get; set; }
        public long TemplateServerId { get; set; }
    }
}
