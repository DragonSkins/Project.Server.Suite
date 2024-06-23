using Project.Server.Suite.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Server.Suite.Base
{
    public class WorkerLable : IWorkerLable
    {
        public long WorkerLableId { get; set; }
        public string LableName { get; set; }
        public string? Description { get; set; }
        public WorkerAssignedLable WorkerAssignedLables { get; set; }
    }
}
