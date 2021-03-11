using PokemonStatCalculator.Utils.Monads.Results;

namespace PokemonStatCalculator.Entities.Stats.EffortValues
{
    public interface IEffortValueBuilder
    {
        Result<EffortValue> Build();
    }
}