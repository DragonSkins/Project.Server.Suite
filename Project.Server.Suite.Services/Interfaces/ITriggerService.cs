using Project.Server.Suite.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Server.Suite.Services.Interfaces
{
    public interface ITriggerService
    {
        IEnumerable<Trigger> GetTriggers(params long[] triggerIds);

        Task<int> SetTriggerAsync(Trigger trigger);

        Task<int> UpdateTriggerAsync(Trigger trigger);

        Task<int> DeleteTriggerAsync(long triggerId);
    }
}
