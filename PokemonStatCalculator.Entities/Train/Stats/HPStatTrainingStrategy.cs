using PokemonStatCalculator.Entities.Pokemons;
using PokemonStatCalculator.Entities.Stats;
using PokemonStatCalculator.Utils.ExtensionMethods;
using PokemonStatCalculator.Utils.Monads.Results;

namespace PokemonStatCalculator.Entities.Train.Stats
{
    public class HPStatTrainingStrategy : IStatTrainingStrategy
    {
        // This training strategy uses the formula defined since the third generation of Pokémon.
        public Result<Stat> ApplyStatTrainingTo(Pokemon pokemon, Training training, IStatTrainingChecker statTrainingChecker)
        {
            int hpBaseStatValue = pokemon.BaseStats.GetBaseStatValue(PokemonStat.HP);

            int hpIndividualValue = training.IndividualValues.GetIndividualValue(PokemonStat.HP);

            int hpEffortValue = training.EffortValues.GetEffortValue(PokemonStat.HP);

            int currentLevel = training.Level.CurrentLevel;

            int trainedHPValue = ApplyHPStatFormula(hpBaseStatValue, hpIndividualValue, hpEffortValue, currentLevel);

            return statTrainingChecker.CheckIfTrainingIsAcceptedFor(trainedHPValue, PokemonStat.HP, training, pokemon)
                ? Result.Success<Stat>(new HPStat(trainedHPValue))
                : Result.Fail<Stat>($"The calculated {PokemonStat.HP.GetDescription()} stat is out of the acceptable range.");
        }

        private int ApplyHPStatFormula(int hpBaseStatValue, int hpIndividualValue, int hpEffortValue, int currentLevel)
        {
            return (((2 * hpBaseStatValue) + hpIndividualValue + (hpEffortValue / 4)) * currentLevel / 100) + currentLevel + 10;
        }
    }
}