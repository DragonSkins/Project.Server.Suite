using Project.Server.Suite.Base;

namespace Project.Server.Suite.Services.Interfaces
{
    public interface IProjectServerService
    {
        IEnumerable<ProjectServer> GetProjectServers(params long[] serverIds);

        Task<int> SetProjectServerAsync(ProjectServer projectServer);

        Task<int> UpdateProjectServerAsync(ProjectServer projectServer);

        Task<int> DeleteProjectServerAsync(long serverId);
    }
}
