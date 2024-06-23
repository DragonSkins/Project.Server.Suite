using Project.Server.Suite.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Server.Suite.Base
{
    public class TaskSettingType : ITaskSettingType
    {
        public int DefaultSelection { get; set; }
        public string? Description { get; set; }
        public string Name { get; set; }
        public ICollection<Setting> Settings { get; set; }
        public long TaskSettingTypeId { get; set; }
    }
}
