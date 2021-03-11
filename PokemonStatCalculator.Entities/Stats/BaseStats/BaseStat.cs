using System.Collections.Generic;
using PokemonStatCalculator.Utils.ExtensionMethods;
using PokemonStatCalculator.Utils.Monads.Results;

namespace PokemonStatCalculator.Entities.Stats.BaseStats
{
    public sealed class BaseStat
    {
        private readonly IDictionary<PokemonStat, Stat> baseStats;

        public BaseStat()
        {
            baseStats = new Dictionary<PokemonStat, Stat>();
        }

        public Result ApplyBaseStat(Stat stat)
        {
            if (stat.Number < 0)
            {
                return Result.Fail($"The stat number of {stat.Classification.GetDescription()} must be greater than 0.");
            }

            baseStats[stat.Classification] = stat;

            return Result.Success();
        }

        public int GetBaseStatValue(PokemonStat baseStat)
        {
            return baseStats.ContainsKey(baseStat) ? baseStats[baseStat].Number : 0;
        }
    }
}