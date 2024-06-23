using Project.Server.Suite.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Server.Suite.Base
{
    public class TaskProject : ITaskProject
    {
        public int Destination { get; set; }
        public PssTask PssTask { get; set; }
        public long PssTaskId { get; set; }
        public long TaskProjectId { get; set; }
        public TiaProject TiaProject { get; set; }
        public long TiaProjectId { get; set; }
    }
}
