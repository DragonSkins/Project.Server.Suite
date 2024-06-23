using Project.Server.Suite.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Server.Suite.Base
{
    public class WorkerAssignedLable : IWorkerAssignedLable
    {
        public long WorkerAssignedLableId { get; set; }
        public long WorkerId { get; set; }
        public long WorkerLableId { get; set; }
        public Worker Worker { get; set; }
        public WorkerLable WorkerLable { get; set; }
    }
}
