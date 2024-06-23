using Project.Server.Suite.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Server.Suite.Base
{
    public class TaskSetting : ITaskSetting
    {
        public PssTask PssTask { get; set; }
        public long PssTaskId { get; set; }
        public Setting Setting { get; set; }
        public long SettingId { get; set; }
        public long TaskSettingId { get; set; }
    }
}
