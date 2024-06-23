using Project.Server.Suite.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Server.Suite.Base
{
    public class PssWorkerLable : IPssWorkerLable
    {
        public string? Description { get; set; }
        public string LableName { get; set; }
        public long PssWorkerLableId { get; set; }
    }
}
