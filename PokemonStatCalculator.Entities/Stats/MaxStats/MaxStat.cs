using PokemonStatCalculator.Utils.ExtensionMethods;

namespace PokemonStatCalculator.Entities.Stats.MaxStats
{
    public class MaxStat
    {
        public MaxStat(PokemonStat maxStatFor, Stat initialStatRange, Stat finalStatRange)
        {
            MaxStatFor = maxStatFor;
            InitialStatRange = initialStatRange;
            FinalStatRange = finalStatRange;
        }

        public PokemonStat MaxStatFor { get; private set; }

        public Stat InitialStatRange { get; private set; }

        public Stat FinalStatRange { get; private set; }

        public bool CheckIfStatIsInAcceptedRange(Stat stat)
        {
            return stat.Number.IsBetween(InitialStatRange.Number, FinalStatRange.Number);
        }
    }
}