using Microsoft.AspNetCore.Mvc;

namespace RPTA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : Controller
    {
        private readonly RptaDbContext _context;

        public ItemController(RptaDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _context.Item.ToListAsync());
        }
    }
}
