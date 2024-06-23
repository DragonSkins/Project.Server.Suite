
namespace Project.Server.Suite.Base.Interfaces
{
    public interface ITiaProject
    {
        string ChangedAt { get; set; }
        string ChangedBy { get; set; }
        string CreatedAt { get; set; }
        string CreatedBy { get; set; }
        string? Description { get; set; }
        int DoRevisionCheck { get; set; }
        ProjectGroup ProjectGroup { get; set; }
        long ProjectGroupId { get; set; }
        string ProjectName { get; set; }
        ProjectServer ProjectServer { get; set; }
        long ProjectServerId { get; set; }
        string ProjectType { get; set; }
        string ProjectVersion { get; set; }
        //ICollection<Revision> Revisions { get; set; }
        //ICollection<TaskProject> TaskProjects { get; set; }
        //ICollection<TemplateProject> TemplateProjects { get; set; }
        long TiaProjectId { get; set; }
    }
}