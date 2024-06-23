using Project.Server.Suite.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Server.Suite.Base
{
    public class TemplateParameter : ITemplateParameter
    {
        public ActionParameter ActionParameter { get; set; }
        public long ActionParameterId { get; set; }
        public string? ParameterValue { get; set; }
        public Template Template { get; set; }
        public long TemplateId { get; set; }
        public long TemplateParameterId { get; set; }
    }
}
