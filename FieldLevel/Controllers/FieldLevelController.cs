using FieldLevel.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FieldLevel.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FieldLevelController : ControllerBase
    {
        private readonly IPostService _service;

        public FieldLevelController(IPostService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var posts = await _service.GetAllPosts();
            return Ok(posts);
        }
    }
}