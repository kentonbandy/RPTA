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
                .Include(c => c.Inventory)
                .ThenInclude(i => i.Item)
                .ThenInclude(i => i.Text)
                .ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Character>> Get(int id)
        {
            var character = await _context.Character.FindAsync(id);
            if (character == null)
            {
                return BadRequest("Character not found");
            }
            return Ok(await _context.Character
                .Include(c => c.Pronouns)
                .Include(c => c.Text)
                .Include(c => c.Inventory)
                .ThenInclude(i => i.Item)
                .ThenInclude(i => i.Text)
                .FirstAsync(c => c.CharacterId == id));
        }

        [HttpPost]
        public async Task<IActionResult> Create(Character character)
        {

            if (character.Pronouns.PronounsId <= 0 )
            {
                character.Pronouns = await _context.Pronouns
                    .FirstOrDefaultAsync(p =>
                        p.SingularNominative == character.Pronouns.SingularNominative &&
                        p.ThirdObjective == character.Pronouns.ThirdObjective &&
                        p.PossessiveNominative == character.Pronouns.PossessiveNominative &&
                        p.PossessiveObjective == character.Pronouns.PossessiveObjective)
                    ?? new Pronouns()
                    {
                        SingularNominative = character.Pronouns.SingularNominative,
                        ThirdObjective = character.Pronouns.ThirdObjective,
                        PossessiveNominative = character.Pronouns.PossessiveNominative,
                        PossessiveObjective = character.Pronouns.PossessiveObjective
                    };
            }
            else
            {
                character.Pronouns = await _context.Pronouns
                    .FirstOrDefaultAsync(p =>
                    p.PronounsId == character.Pronouns.PronounsId)
                    ?? await _context.Pronouns
                    .FirstOrDefaultAsync(p =>
                        p.SingularNominative == character.Pronouns.SingularNominative &&
                        p.ThirdObjective == character.Pronouns.ThirdObjective &&
                        p.PossessiveNominative == character.Pronouns.PossessiveNominative &&
                        p.PossessiveObjective == character.Pronouns.PossessiveObjective)
                    ?? new Pronouns();
            }
            _context.Character.Add(character);
            await _context.SaveChangesAsync();
            return Ok(await _context.Character
                .Include(c => c.Pronouns)
                .Include(c => c.Text)
                .Include(c => c.Inventory)
                .ThenInclude(i => i.Item)
                .ThenInclude(i => i.Text)
                .FirstAsync(c => c.CharacterId == character.CharacterId));
        }
    }
}
