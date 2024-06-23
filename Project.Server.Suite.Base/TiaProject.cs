using Project.Server.Suite.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Server.Suite.Base
{
    public class TiaProject : ITiaProject
    {
        public string ChangedAt { get; set; }
        public string ChangedBy { get; set; }
        public string CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string? Description { get; set; }
        public int DoRevisionCheck { get; set; }
        public ProjectGroup ProjectGroup { get; set; }
        public long ProjectGroupId { get; set; }
        public string ProjectName { get; set; }
        public ProjectServer ProjectServer { get; set; }
        public long ProjectServerId { get; set; }
        public string ProjectType { get; set; }
        public string ProjectVersion { get; set; }
        //public ICollection<Revision> Revisions { get; set; }
        //public ICollection<TaskProject> TaskProjects { get; set; }
        //public ICollection<TemplateProject> TemplateProjects { get; set; }
        public long TiaProjectId { get; set; }
    }
}
