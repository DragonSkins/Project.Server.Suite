using Project.Server.Suite.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Server.Suite.Base
{
    public class Revision : IRevision
    {
        public string Author { get; set; }
        public int InputNotification { get; set; }
        public string LastModified { get; set; }
        public string Modified { get; set; }
        public string Notice { get; set; }
        public int ProjectRevision { get; set; }
        public string? RevisionHash { get; set; }
        public long RevisionId { get; set; }
        public int SendNotification { get; set; }
        public ICollection<TaskExecuteRevision> TaskExecuteRevisions { get; set; }
        public string Tested { get; set; }
        public TiaProject TiaProject { get; set; }
        public long TiaProjectId { get; set; }
    }
}
