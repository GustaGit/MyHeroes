using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using myHeroesAPI.Data;
using myHeroesAPI.Models;

namespace myHeroesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeroesController : Controller
    {
        private readonly DataContext _context;
        public HeroesController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Hero>>> GetHeroes()
        {
            return Ok(await _context.Hero.ToListAsync());
        }
    }
}
