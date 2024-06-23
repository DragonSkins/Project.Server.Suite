using Microsoft.EntityFrameworkCore;
using Project.Server.Suite.Data.Entities;
using Project.Server.Suite.Data.Interfaces;

namespace Project.Server.Suite.Data.Repositories
{
    public class TriggerRepository : RepositoryCrud<Trigger>, ITriggerRepositoryCrud
    {
        public TriggerRepository(DbContext context) : base(context)
        {
        }
    }
}
