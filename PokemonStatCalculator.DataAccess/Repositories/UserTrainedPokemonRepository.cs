using PokemonStatCalculator.DataAccess.Contexts;
using PokemonStatCalculator.DataAccess.DataModels.UserTrainedPokemonCollection;

namespace PokemonStatCalculator.DataAccess.Repositories
{
    public class UserTrainedPokemonRepository : BaseRepository<UserTrainedPokemon>, IUserTrainedPokemonRepository
    {
        public UserTrainedPokemonRepository(IMongoContext context)
            : base(context)
        {
        }
    }
}