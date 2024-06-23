using Project.Server.Suite.Base;
using Project.Server.Suite.Data.Interfaces;
using Project.Server.Suite.Services.Interfaces;
using Project.Server.Suite.Services.Mappers;

namespace Project.Server.Suite.Services
{
    public class ProjectServerService : IProjectServerService
    {
        private readonly IProjectServerRepositoryCrud _projectServerRepositoryCrud;

        public ProjectServerService(IProjectServerRepositoryCrud projectServerRepositoryCrud) 
        { 
            _projectServerRepositoryCrud = projectServerRepositoryCrud;
        }
        
        public IEnumerable<ProjectServer> GetProjectServers(params long[] serverIds)
        {
            var servers = _projectServerRepositoryCrud.Get(c => serverIds.Any(id => c.ProjectServerId == id) || serverIds.Length == 0);

            foreach (var entity in servers)
                yield return EntityToModel.CreateProjectServerFromEntity(entity);
        }

        public async Task<int> SetProjectServerAsync(ProjectServer projectServer)
        {
            var entity = ModelToEntity.CreateEntityFromProjectServer(projectServer);
            await _projectServerRepositoryCrud.InsertAsync(entity);
            var rowsAffected = await _projectServerRepositoryCrud.SaveChangesAsync();
            return rowsAffected;
        }

        public async Task<int> UpdateProjectServerAsync(ProjectServer projectServer)
        {
            var entity = ModelToEntity.UpdateEntityFromProjectServer(_projectServerRepositoryCrud.Get(t => t.ProjectServerId == projectServer.ProjectServerId).FirstOrDefault()!, projectServer);
            _projectServerRepositoryCrud.Update(entity);
            var rowsAffected = await _projectServerRepositoryCrud.SaveChangesAsync();
            return rowsAffected;
        }

        public async Task<int> DeleteProjectServerAsync(long serverId)
        {
            var entity = _projectServerRepositoryCrud.Get(t => t.ProjectServerId == serverId).FirstOrDefault();
            if (entity == null)
                return 0;

            if (entity.TemplateServers.Any())
                throw new Exception("Cannot delete a project server that has templates enrolled in it");

            if (entity.TaskServers.Any())
                throw new Exception("Cannot delete a project server that has tasks enrolled in it");

            if (entity.TiaProjects.Any())
                throw new Exception("Cannot delete a project server that has projects enrolled in it");

            if (entity.ProjectGroups.Any())
                throw new Exception("Cannot delete a project server that has groups enrolled in it");

            _projectServerRepositoryCrud.Delete(entity);
            var rowsAffected = await _projectServerRepositoryCrud.SaveChangesAsync();
            return rowsAffected;
        }
    }
}
