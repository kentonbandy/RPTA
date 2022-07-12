using Microsoft.AspNetCore.Mvc;

namespace RPTA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterController : Controller
    {
        private readonly RptaDbContext _context;

        public CharacterController(RptaDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _context.Character
                .Include(c => c.Pronouns)
                .Include(c => c.Text)
                .Include(c => c.Items)
                .ThenInclude(i => i.Item)
                .ThenInclude(i => i.Text)
                .ToListAsync());
        }
    }
}
