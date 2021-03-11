using System.Collections.Generic;
using System.Linq;
using PokemonStatCalculator.Utils.ExtensionMethods;
using PokemonStatCalculator.Utils.Monads.Results;

namespace PokemonStatCalculator.Entities.Stats.EffortValues
{
    public sealed class EffortValue
    {
        private const int MaxEffortValuesSum = 510;

        private const int MaxEffortValueToStat = 255;

        private const int FullyEffortValue = 252;

        private const int ZeroedEffortValue = 0;

        private readonly IDictionary<PokemonStat, Stat> effortValues;

        public EffortValue()
        {
            effortValues = new Dictionary<PokemonStat, Stat>();
        }

        public Result ApplyEffortValue(Stat effortValue)
        {
            if (effortValue.Number.IsNotBetween(ZeroedEffortValue, MaxEffortValueToStat))
            {
                return Result.Fail($"The stat number of {effortValue.Classification.GetDescription()} must be between 0 and 255.");
            }

            if (CheckIfNewEffortValueToStatExceedsMaxAcceptedValue(effortValue.Number))
            {
                return Result.Fail($"The stat number of {effortValue.Classification.GetDescription()} exceeds max accepted value.");
            }

            effortValues[effortValue.Classification] = effortValue;

            return Result.Success();
        }

        public int GetEffortValue(PokemonStat stat) => effortValues.ContainsKey(stat) ? effortValues[stat].Number : ZeroedEffortValue;

        public bool CheckIfEffortValuesSumExceedsMaxAcceptedValue() => effortValues.Sum(ev => ev.Value.Number) > MaxEffortValuesSum;

        public bool CheckIfNewEffortValueToStatExceedsMaxAcceptedValue(int newEffortValue) => GetEffortValuesSum() + newEffortValue > MaxEffortValuesSum;

        public int GetEffortValuesSum() => effortValues.Sum(ev => ev.Value.Number);

        public int GetMaxEffortValueSumAccepted() => MaxEffortValuesSum;

        public IEnumerable<Stat> GetAllFullyTrainedStats() => effortValues.Where(ev => ev.Value.Number >= FullyEffortValue).Select(ev => ev.Value);

        public IEnumerable<Stat> GetAllEffortedStats() => effortValues.Where(ev => ev.Value.Number != ZeroedEffortValue).Select(ev => ev.Value);

        public IEnumerable<Stat> GetAllNotEffortedStats() => effortValues.Where(ev => ev.Value.Number == ZeroedEffortValue).Select(ev => ev.Value);
    }
}