using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface IPokemonRepository
    {
        Task<ICollection<Pokemon>> GetAllPokemonsAsync();
        Pokemon GetPokemon(int pokemonNumber);
        Pokemon GetPokemon(string name);
        bool PokemonExist(int pokemonNumber);
    }
}
