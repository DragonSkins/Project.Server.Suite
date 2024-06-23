using Project.Server.Suite.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Server.Suite.Base
{
    public class TaskServer : ITaskServer
    {
        public int Destination { get; set; }
        public ProjectServer ProjectServer { get; set; }
        public long ProjectServerId { get; set; }
        //public PssTask PssTask { get; set; }
        public long PssTaskId { get; set; }
        public long TaskServerId { get; set; }
    }
}
