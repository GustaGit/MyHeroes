﻿using Microsoft.AspNetCore.Mvc;

namespace myHeroesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeroesController : Controller
    {
        [HttpGet]
        public async Task<ActionResult<List<HeroModel>>> GetHeroes()
        {
            return new List<HeroModel> {

                new HeroModel
                {
                    Id = 1,
                    Name = "Bruce Wayne",
                    NameHero = "Batman",
                    Superpowers = new List<string>{"Inteligencia","Artes Marciais", "Super-Detetive"},
                    Birthdate = DateTime.Now,
                    Height = 20,
                    Weight = 66
                }
            };
        }
    }
}