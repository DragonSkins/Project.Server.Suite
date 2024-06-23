using Project.Server.Suite.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Server.Suite.Base
{
    public class TemplateSetting : ITemplateSetting
    {
        public Setting Setting { get; set; }
        public long SettingId { get; set; }
        public Template Template { get; set; }
        public long TemplateId { get; set; }
        public long TemplateSettingId { get; set; }
    }
}
