using KOMiT.App.Service;
using KOMiT.Core.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace KOMiT.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly IProjectService _projectService;
        public ProjectController(IProjectService projectService)
        {
            _projectService = projectService;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<ICollection<Project>>> GetAll()
        {
            var result = await _projectService.GetAll();
            return Ok(result);
        }

        [HttpGet("GetDetailsById/{id}")]
        public async Task<ActionResult<Project>> GetDetailsById(int id)
        {
            var result = await _projectService.GetDetailsById(id);
            return Ok(result);
        }

        [HttpPost("CreateProject")]
        public async Task<ActionResult> CreateProject([FromBody] Project project)
        {
            await _projectService.CreateProject(project);
            return Ok(project);
        }
    }
}
