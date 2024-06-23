using Project.Server.Suite.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Server.Suite.Base
{
    public class Setting : ISetting
    {
        public long SettingId { get; set; }
        public ICollection<TaskSetting> TaskSettings { get; set; }
        public TaskSettingType? TaskSettingType { get; set; }
        public long? TaskSettingTypeId { get; set; }
        public ICollection<TemplateSetting> TemplateSettings { get; set; }
        public int Value { get; set; }
    }
}
