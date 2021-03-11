using PokemonStatCalculator.Entities.Pokemons;
using PokemonStatCalculator.Utils.Monads.Results;

namespace PokemonStatCalculator.Entities.Train
{
    public interface ITrainingStrategy
    {
        Result<PokemonTrained> StartTrainingTo(Pokemon pokemon, Training training);
    }
}