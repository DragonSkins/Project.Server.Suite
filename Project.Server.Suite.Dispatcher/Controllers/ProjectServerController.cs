using Microsoft.AspNetCore.Mvc;
using Project.Server.Suite.Base;
using Project.Server.Suite.Services.Interfaces;

namespace Project.Server.Suite.Dispatcher.Controllers
{
    [ApiController]
    [Route("project-server")]
    public class ProjectServerController : ControllerBase
    {
        private readonly IProjectServerService _projectServerService;

        public ProjectServerController(IProjectServerService projectServerService)
        {
            _projectServerService = projectServerService;
        }

        [Route("")]
        [HttpGet]
        public IActionResult GetAll()
        {
            var server = _projectServerService.GetProjectServers();
            return new OkObjectResult(server);
        }

        [Route("{serverId}")]
        [HttpGet]
        public IActionResult GetProjectServer([FromRoute] long serverId)
        {
            var servers = _projectServerService.GetProjectServers(serverId);
            var server = servers.FirstOrDefault();

            return server == null ? new NotFoundResult() : new OkObjectResult(server);
        }

        [Route("")]
        [HttpPost]
        public async Task<IActionResult> SetProjectServer([FromBody] ProjectServer projectServer)
        {
            var rowsAffected = await _projectServerService.SetProjectServerAsync(projectServer);

            if (rowsAffected > 0)
                return new OkResult();

            throw new Exception($"There was an error creating the project server with id {projectServer.ProjectServerId}");
        }

        [Route("")]
        [HttpPut]
        public async Task<IActionResult> UpdateProjectServer([FromBody] ProjectServer projectServer)
        {
            var rowsAffected = await _projectServerService.UpdateProjectServerAsync(projectServer);

            if (rowsAffected > 0)
                return new OkResult();

            throw new Exception($"There was an error updating the project server with id {projectServer.ProjectServerId}");
        }

        [Route("{serverId}")]
        [HttpDelete]
        public async Task<IActionResult> DeleteProjectServer([FromRoute] long serverId)
        {
            var rowsAffected = await _projectServerService.DeleteProjectServerAsync(serverId);

            if (rowsAffected > 0)
                return new OkResult();

            throw new Exception($"There was an error deleting the project server with id {serverId}");
        }
    }
}
