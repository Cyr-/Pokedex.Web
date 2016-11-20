using System.Collections.Generic;

namespace Pokedex.Web.Models
{
    public class Pokemon
    {
        public Pokemon(Pokeapi.Pokemon.Pokemon apiModel)  
        {
            Name = apiModel.Name;
            Number = apiModel.Id;
            Species = apiModel.Species.Name;

            foreach (Pokeapi.Pokemon.PokemonType type in apiModel.Types)
            {
                Types.Add(new Type(type));
            }
        }

        public string Name { get; set; }
        public int Number { get; set; }
        public List<Type> Types { get; set; } = new List<Type>();
        public string Species { get; set; }
    }
}