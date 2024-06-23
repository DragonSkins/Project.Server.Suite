using Microsoft.EntityFrameworkCore;
using Project.Server.Suite.Data.Entities;
using Project.Server.Suite.Data.Interfaces;

namespace Project.Server.Suite.Data.Repositories
{
    public class ProjectServerRepository : RepositoryCrud<ProjectServer>, IProjectServerRepositoryCrud
    {
        public ProjectServerRepository(DbContext context) : base(context)
        {
        }
    }
}
