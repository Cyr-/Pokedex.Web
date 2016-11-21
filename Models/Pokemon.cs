using System.Collections.Generic;
using System.Linq;

namespace Pokedex.Web.Models
{
    public class Pokemon
    {
        public Pokemon(Pokeapi.Pokemon.Pokemon apiModel)  
        {
            Name = apiModel.Name;
            Number = apiModel.Id;

            foreach (var type in apiModel.Types)
            {
                Types.Add(new Type(type));
            }

            Species = apiModel.Species.Genera.First(x => x.Language.Name == "en").Name;
        }

        public string Name { get; set; }
        public int Number { get; set; }
        public List<Type> Types { get; set; } = new List<Type>();
        public string Species { get; set; }
    }
}