using PokemonStatCalculator.Entities.Pokemons;
using PokemonStatCalculator.Entities.Stats;

namespace PokemonStatCalculator.Entities.Train.Stats
{
    public interface IStatTrainingChecker
    {
        bool CheckIfTrainingIsAcceptedFor(int valueOfTrainedStat, PokemonStat trainedStat, Training training, Pokemon pokemonInTraining);
    }
}