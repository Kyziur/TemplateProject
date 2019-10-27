using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectTemplate.Infrastructure.Services;

namespace ProjectTemplate.Api.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class IssuesController : ApiControllerBase
    {
        private readonly IIsueService _issuesService;

        public IssuesController(IIsueService issuesService)
        {
            _issuesService = issuesService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var tasks = await _issuesService.GetAll();
            return Ok(tasks);
        }

    }
}