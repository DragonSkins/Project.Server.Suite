using Project.Server.Suite.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Server.Suite.Base
{
    public class TaskCollection : ITaskCollection
    {
        public PssTask PssTask { get; set; }
        public long PssTaskId { get; set; }
        public long TaskCollectionId { get; set; }
        public Template Template { get; set; }
        public long TemplateId { get; set; }
    }
}
