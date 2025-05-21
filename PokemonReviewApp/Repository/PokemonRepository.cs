using Microsoft.EntityFrameworkCore;
using PokemonReviewApp.Data;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;
using System.Linq;

namespace PokemonReviewApp.Repository
{
    public class PokemonRepository : IPokemonRepository
    {
        private readonly DataContext _context;
        public PokemonRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<ICollection<Pokemon>> GetAllPokemonsAsync()
        {
            return await _context.Pokemon
                .OrderBy(p => p.PokemonNumber)
                .ToListAsync();
        }

        public async Task<ICollection<Pokemon>> GetPokemonsByNameAsync()
        {
            return await _context.Pokemon
                .OrderBy(p => p.PokemonNumber)
                .ToListAsync();
        }
    }
}
