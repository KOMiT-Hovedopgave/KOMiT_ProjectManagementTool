using KOMiT.App.Service;
using KOMiT.Core.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KOMiT.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrentPhaseController : ControllerBase
    {
        private readonly ICurrentPhaseService _currentPhaseService;
        public CurrentPhaseController(ICurrentPhaseService currentPhaseService)
        {
            _currentPhaseService = currentPhaseService;
        }

        [HttpGet("GetDetailsById/{id}")]
        public async Task<ActionResult<CurrentPhase>> GetDetailsById(int id)
        {
            var result = await _currentPhaseService.GetDetailsById(id);
            return Ok(result);
        }
    }
}
