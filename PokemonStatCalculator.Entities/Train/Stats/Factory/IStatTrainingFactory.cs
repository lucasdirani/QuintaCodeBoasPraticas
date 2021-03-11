using PokemonStatCalculator.Entities.Pokemons;
using PokemonStatCalculator.Entities.Stats;
using PokemonStatCalculator.Utils.Monads.Results;

namespace PokemonStatCalculator.Entities.Train.Stats.Factory
{
    public interface IStatTrainingFactory
    {
        Result<Stat> BuildStatWith(PokemonStat pokemonStat, Pokemon pokemon, Training training);
    }
}