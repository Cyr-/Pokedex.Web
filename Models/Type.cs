namespace Pokedex.Web.Models
{
    public class Type
    {
        public Type(Pokeapi.Pokemon.PokemonType apiModel)
        {
            Name = apiModel.Type.Name;
        }

        public string Name { get; set; }
    }
}