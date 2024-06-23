
namespace Project.Server.Suite.Base.Interfaces
{
    public interface IProjectServer
    {
        string? Description { get; set; }
        int DoRevisionCheck { get; set; }
        string HostName { get; set; }
        int PortNumber { get; set; }
        ICollection<ProjectGroup> ProjectGroups { get; set; }
        long ProjectServerId { get; set; }
        string ServerName { get; set; }
        string ServerUrl { get; set; }
        int Status { get; set; }
        ICollection<TaskServer> TaskServers { get; set; }
        ICollection<TemplateServer> TemplateServers { get; set; }
        ICollection<TiaProject> TiaProjects { get; set; }
    }
}