using PokemonStatCalculator.Utils.Monads.Results;

namespace PokemonStatCalculator.Entities.Stats.IndividualValues
{
    public interface IIndividualValueBuilder
    {
        Result<IndividualValue> Build();
    }
}