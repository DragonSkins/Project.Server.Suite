using Project.Server.Suite.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Server.Suite.Base
{
    public class Worker : IWorker
    {
        public long WorkerId { get; set; }
        public string WorkerName { get; set; }
        public int Status { get; set; }
        public string? Description { get; set; }
        public string KeepAlive { get; set; }
        public ICollection<WorkerAssignedLable> WorkerAssignedLables { get; set; }
    }
}
