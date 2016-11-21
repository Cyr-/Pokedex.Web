using System;
using Microsoft.AspNetCore.Mvc;
using Pokedex.Pokeapi.Pokemon;
using Pokedex.Logic.Web;

namespace Pokedex.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Pokemon(int id = 1)
        {
            var apiModel = DataFetcher.GetApiObject<Pokemon>(new Uri("http://pokeapi.co/api/v2/pokemon/" + id)).Result;
            apiModel.Species = DataFetcher.GetApiObject<PokemonSpecies>(new Uri("http://pokeapi.co/api/v2/pokemon-species/" + id)).Result;
            var model = new Models.Pokemon(apiModel);
            return View(model);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}