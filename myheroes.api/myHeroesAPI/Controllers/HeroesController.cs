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

        [HttpPost]
        public async Task<ActionResult<List<Hero>>> InsertHero(Hero newHero)
        {
            _context.Hero.Add(newHero);
            await _context.SaveChangesAsync();

            return Ok(await _context.Hero.ToListAsync());
        }
        [HttpPut]
        public async Task<ActionResult<List<Hero>>> UpdateHero(Hero hero)
        {
            var dbHero = await _context.Hero.FindAsync(hero.Id);
            if (dbHero == null)
                return BadRequest("Hero not found.");

            dbHero.Name = hero.Name;
            dbHero.NameHero = hero.NameHero;
            if(hero.Birthdate is not null)
                dbHero.Birthdate = hero.Birthdate;
            dbHero.Height = hero.Height;
            dbHero.Weight = hero.Weight;

            await _context.SaveChangesAsync();

            return Ok(await _context.Hero.ToListAsync());
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Hero>>> DeleteHero(int id)
        {
            var dbHero = await _context.Hero.FindAsync(id);
            if (dbHero == null)
                return BadRequest("Hero not found.");
            _context.Remove(dbHero);
            await _context.SaveChangesAsync();

            return Ok(await _context.Hero.ToListAsync());
        }
    }
}
