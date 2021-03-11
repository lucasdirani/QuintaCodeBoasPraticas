using PokemonStatCalculator.Entities.Pokemons;
using PokemonStatCalculator.Entities.Stats;
using PokemonStatCalculator.Utils.Monads.Results;

namespace PokemonStatCalculator.Entities.Train.Stats
{
    public interface IStatTrainingStrategy
    {
        Result<Stat> ApplyStatTrainingTo(Pokemon pokemon, Training training, IStatTrainingChecker statTrainingChecker);
    }
}