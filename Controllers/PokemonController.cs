using System;
using Microsoft.AspNetCore.Mvc;
using Pokedex.Pokeapi.Pokemon;
using Pokedex.Logic.Web;

namespace Pokedex.Web.Controllers
{
    public class PokemonController : Controller
    {
        public IActionResult Index(int id = 1)
        {
            var model = DataFetcher.GetApiObject<Pokemon>(new Uri("http://pokeapi.co/api/v2/pokemon/" + id)).Result;
            return View(model);
        }
    }
}