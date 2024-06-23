using Project.Server.Suite.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Server.Suite.Base
{
    public class ProjectGroup : IProjectGroup
    {
        public string? Description { get; set; }
        public int DoRevisionCheck { get; set; }
        public string Name { get; set; }
        public long ProjectGroupId { get; set; }
        public ProjectServer ProjectServer { get; set; }
        public long ProjectServerId { get; set; }
        public ICollection<TiaProject> TiaProjects { get; set; }
    }
}
