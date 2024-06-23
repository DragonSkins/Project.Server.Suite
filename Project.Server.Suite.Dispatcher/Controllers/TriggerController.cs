using Microsoft.AspNetCore.Mvc;
using Project.Server.Suite.Base;
using Project.Server.Suite.Services.Interfaces;

namespace Project.Server.Suite.Dispatcher.Controllers
{
    [ApiController]
    [Route("trigger")]
    public class TriggerController : ControllerBase
    {
        private readonly ITriggerService _triggerService;

        public TriggerController(ITriggerService triggerService)
        {
            _triggerService = triggerService;
        }

        [Route("")]
        [HttpGet]
        public IActionResult GetAll()
        {
            var trigger = _triggerService.GetTriggers();
            return new OkObjectResult(trigger);
        }

        [Route("{triggerId}")]
        [HttpGet]
        public IActionResult GetTrigger([FromRoute] long triggerId)
        {
            var triggers = _triggerService.GetTriggers(triggerId);
            var trigger = triggers.FirstOrDefault();

            return trigger == null ? new NotFoundResult() : new OkObjectResult(trigger);
        }

        [Route("")]
        [HttpPost]
        public async Task<IActionResult> SetTrigger([FromBody] Trigger trigger)
        {
            var rowsAffected = await _triggerService.SetTriggerAsync(trigger);

            if (rowsAffected > 0)
                return new OkResult();

            throw new Exception($"There was an error creating the trigger with id {trigger.TriggerId}");
        }

        [Route("")]
        [HttpPut]
        public async Task<IActionResult> UpdateTrigger([FromBody] Trigger trigger)
        {
            var rowsAffected = await _triggerService.UpdateTriggerAsync(trigger);

            if (rowsAffected > 0)
                return new OkResult();

            throw new Exception($"There was an error updating the trigger with id {trigger.TriggerId}");
        }

        [Route("{triggerId}")]
        [HttpDelete]
        public async Task<IActionResult> DeleteTrigger([FromRoute] long triggerId)
        {
            var rowsAffected = await _triggerService.DeleteTriggerAsync(triggerId);

            if (rowsAffected > 0)
                return new OkResult();

            throw new Exception($"There was an error deleting the trigger with id {triggerId}");
        }
    }
}
