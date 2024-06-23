using Project.Server.Suite.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Server.Suite.Base
{
    public class TaskExecuteRevision : ITaskExecuteRevision
    {
        public PssTask? PssTask { get; set; }
        public long? PssTaskId { get; set; }
        public Revision? Revision { get; set; }
        public long? RevisionId { get; set; }
        public int Status { get; set; }
        public long TaskExecuteRevisionId { get; set; }
    }
}
