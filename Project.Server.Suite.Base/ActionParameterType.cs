using Project.Server.Suite.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Server.Suite.Base
{
    public class ActionParameterType : IActionParameterType
    {
        public ICollection<ActionParameter> ActionParameters { get; set; }
        public long ActionParameterTypeId { get; set; }
        public string Key { get; set; }
        public string KeyAlias { get; set; }
        public string? KeyCmd { get; set; }
        public int ParameterType { get; set; }
        public string ToolTip { get; set; }
        public int Visibility { get; set; }
    }
}
