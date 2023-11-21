using KOMiT.App.Service;
using KOMiT.Core.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KOMiT.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StandardPhaseController : ControllerBase
    {
        private readonly IStandardPhaseService _standardPhaseService;
        public StandardPhaseController(IStandardPhaseService standardPhaseService)
        {
            _standardPhaseService = standardPhaseService;
        }
        [HttpPost("CreatePhase")]
        public async Task<ActionResult<ICollection<StandardPhase>>> CreatePhase([FromBody] StandardPhase standardPhase)
        {
            if (standardPhase == null)
            {
                return BadRequest("NoPhase");
            }
            var result = await _standardPhaseService.CrreatePhase();
            return Ok(result);
        }


    }



}
