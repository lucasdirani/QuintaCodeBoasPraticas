using System.Collections.Generic;
using System.Linq;
using PokemonStatCalculator.Utils.ExtensionMethods;
using PokemonStatCalculator.Utils.Monads.Results;

namespace PokemonStatCalculator.Entities.Stats.IndividualValues
{
    public sealed class IndividualValue
    {
        private const int PerfectIndividualValue = 31;

        private const int ZeroedIndividualValue = 0;

        private readonly IDictionary<PokemonStat, Stat> individualValues;

        public IndividualValue()
        {
            individualValues = new Dictionary<PokemonStat, Stat>();
        }

        public Result ApplyIndividualValue(Stat individualValue)
        {
            if (individualValue.Number.IsNotBetween(ZeroedIndividualValue, PerfectIndividualValue))
            {
                return Result.Fail($"The stat number of {individualValue.Classification.GetDescription()} must be between 0 and 31.");
            }

            individualValues[individualValue.Classification] = individualValue;

            return Result.Success();
        }

        public bool CheckIfHasAllPerfectIndividualValues() => individualValues.All(iv => iv.Value.Number == PerfectIndividualValue);

        public int GetIndividualValue(PokemonStat stat) => individualValues.ContainsKey(stat) ? individualValues[stat].Number : ZeroedIndividualValue;

        public IEnumerable<Stat> GetPerfectStats() => individualValues.Where(iv => iv.Value.Number == PerfectIndividualValue).Select(iv => iv.Value);

        public IEnumerable<Stat> GetZeroedStats() => individualValues.Where(iv => iv.Value.Number == ZeroedIndividualValue).Select(iv => iv.Value);
    }
}