using System.Collections.Generic;

namespace PokemonStatCalculator.Entities.Stats.TrainedStats
{
    public sealed class TrainedStat
    {
        private readonly IDictionary<PokemonStat, Stat> trainedStats;

        public TrainedStat(IEnumerable<Stat> stats)
        {
            trainedStats = new Dictionary<PokemonStat, Stat>();

            ApplyTrainedStats(stats);
        }

        public int GetBaseStatValue(PokemonStat baseStat)
        {
            return trainedStats.ContainsKey(baseStat) ? trainedStats[baseStat].Number : 0;
        }

        private void ApplyTrainedStats(IEnumerable<Stat> stats)
        {
            foreach (var stat in stats)
            {
                trainedStats[stat.Classification] = stat;
            }
        }
    }
}