using Project.Server.Suite.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Server.Suite.Base
{
    public class TaskParameter : ITaskParameter
    {
        public ActionParameter ActionParameter { get; set; }
        public long ActionParameterId { get; set; }
        public string? ParameterValue { get; set; }
        public PssTask PssTask { get; set; }
        public long PssTaskId { get; set; }
        public long TaskParameterId { get; set; }
    }
}
