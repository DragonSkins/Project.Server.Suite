using Project.Server.Suite.Base;
using Project.Server.Suite.Data.Interfaces;
using Project.Server.Suite.Services.Interfaces;
using Project.Server.Suite.Services.Mappers;

namespace Project.Server.Suite.Services
{
    public class TriggerService : ITriggerService
    {
        private readonly ITriggerRepositoryCrud _triggerRepository;

        public TriggerService(ITriggerRepositoryCrud triggerRepository)
        {
            _triggerRepository = triggerRepository;
        }

        public IEnumerable<Trigger> GetTriggers(params long[] triggerIds)
        {
            var triggers = _triggerRepository.Get(c => triggerIds.Any(id => c.TriggerId == id) || triggerIds.Length == 0);

            foreach (var entity in triggers)
                yield return EntityToModel.CreateTriggerFromEntity(entity);
        }

        public async Task<int> SetTriggerAsync(Trigger trigger)
        {
            var entity = ModelToEntity.CreateEntityFromTrigger(trigger);
            await _triggerRepository.InsertAsync(entity);
            var rowsAffected = await _triggerRepository.SaveChangesAsync();
            return rowsAffected;
        }

        public async Task<int> UpdateTriggerAsync(Trigger trigger)
        {
            var entity = ModelToEntity.UpdateEntityFromTrigger(_triggerRepository.Get(t => t.TriggerId == trigger.TriggerId).FirstOrDefault()!, trigger);
            _triggerRepository.Update(entity);
            var rowsAffected = await _triggerRepository.SaveChangesAsync();
            return rowsAffected;
        }

        public async Task<int> DeleteTriggerAsync(long triggerId)
        {
            var entity = _triggerRepository.Get(t => t.TriggerId == triggerId).FirstOrDefault();
            if(entity == null)
                return 0;

            if (entity.Templates.Any())
                throw new Exception("Cannot delete a trigger that has templates enrolled in it");

            _triggerRepository.Delete(entity);
            var rowsAffected = await _triggerRepository.SaveChangesAsync();
            return rowsAffected;
        }
    }
}
