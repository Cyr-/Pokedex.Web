using System.Collections.Generic;

namespace Pokedex.Web.Models
{
    public class Pokemon
    {
        public Pokemon(Pokeapi.Pokemon.Pokemon apiModel)  
        {
            Name = apiModel.Name;
            Number = apiModel.Id;

            foreach (Pokeapi.Pokemon.PokemonType type in apiModel.Types)
            {
                Types.Add(new Type(type));
            }

            foreach (Pokeapi.Pokemon.Genus genus in apiModel.Species.Genera)
            {
                Species.Add(genus.Name);
            }
        }

        public string Name { get; set; }
        public int Number { get; set; }
        public List<Type> Types { get; set; } = new List<Type>();
        public List<string> Species { get; set; }
    }
}