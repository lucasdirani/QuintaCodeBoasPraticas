using System.Collections.Generic;
using System.Linq;
using PokemonStatCalculator.Entities.Pokemons;
using PokemonStatCalculator.Entities.Stats;
using PokemonStatCalculator.Entities.Stats.TrainedStats;
using PokemonStatCalculator.Entities.Train.Stats.Factory;
using PokemonStatCalculator.Utils.ExtensionMethods;
using PokemonStatCalculator.Utils.Monads.Results;

namespace PokemonStatCalculator.Entities.Train
{
    public sealed class DefaultTrainingStrategy : ITrainingStrategy
    {
        private readonly IStatTrainingFactory statTrainingFactory;

        private readonly IEnumerable<PokemonStat> statsToBeTrained = new List<PokemonStat>
        {
            PokemonStat.HP, PokemonStat.Attack, PokemonStat.Defense,
            PokemonStat.SpecialAttack, PokemonStat.SpecialDefense, PokemonStat.Speed,
        };

        public DefaultTrainingStrategy(IStatTrainingFactory statTrainingFactory)
        {
            this.statTrainingFactory = statTrainingFactory;
        }

        public Result<PokemonTrained> StartTrainingTo(Pokemon pokemon, Training training)
        {
            var calculatedStats = new List<Result<Stat>>();

            foreach (var statToBeTrained in statsToBeTrained)
            {
                Result<Stat> calculatedStat = statTrainingFactory.BuildStatWith(statToBeTrained, pokemon, training);

                calculatedStats.Add(calculatedStat);
            }

            if (calculatedStats.ContainsAnyFailure())
            {
                return Result.Fail<PokemonTrained>(calculatedStats.ExtractAllErrors());
            }

            TrainedStat trainedStats = new TrainedStat(calculatedStats.Select(c => c.Value));

            return Result.Success(new PokemonTrained(pokemon, trainedStats, training));
        }
    }
}