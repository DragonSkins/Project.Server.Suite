
namespace Project.Server.Suite.Base.Interfaces
{
    public interface IProjectGroup
    {
        string? Description { get; set; }
        int DoRevisionCheck { get; set; }
        string Name { get; set; }
        long ProjectGroupId { get; set; }
        ProjectServer ProjectServer { get; set; }
        long ProjectServerId { get; set; }
        ICollection<TiaProject> TiaProjects { get; set; }
    }
}