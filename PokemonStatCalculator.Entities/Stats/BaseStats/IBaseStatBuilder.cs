using PokemonStatCalculator.Utils.Monads.Results;

namespace PokemonStatCalculator.Entities.Stats.BaseStats
{
    public interface IBaseStatBuilder
    {
        Result<BaseStat> Build();
    }
}