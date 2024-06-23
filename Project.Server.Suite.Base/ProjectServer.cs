using Project.Server.Suite.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Server.Suite.Base
{
    public class ProjectServer : IProjectServer
    {
        public string? Description { get; set; }
        public int DoRevisionCheck { get; set; }
        public string HostName { get; set; }
        public int PortNumber { get; set; }
        public long ProjectServerId { get; set; }
        public string ServerName { get; set; }
        public string ServerUrl { get; set; }
        public int Status { get; set; }
        public ICollection<TemplateServer> TemplateServers { get; set; }
        public ICollection<TaskServer> TaskServers { get; set; }
        public ICollection<TiaProject> TiaProjects { get; set; }
        public ICollection<ProjectGroup> ProjectGroups { get; set; }
    }
}
