using Project.Server.Suite.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Server.Suite.Base
{
    public class ActionParameter : IActionParameter
    {
        public long ActionParameterId { get; set; }
        public ActionParameterType? ActionParameterType { get; set; }
        public long? ActionParameterTypeId { get; set; }
        public string? Key { get; set; }
        public ICollection<TaskParameter> TaskParameters { get; set; }
        public ICollection<TemplateParameter> TemplateParameters { get; set; }
        public int Value { get; set; }
    }
}
