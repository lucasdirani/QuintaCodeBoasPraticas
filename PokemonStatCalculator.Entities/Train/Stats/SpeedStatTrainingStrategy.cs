using System;
using PokemonStatCalculator.Entities.Pokemons;
using PokemonStatCalculator.Entities.Stats;
using PokemonStatCalculator.Utils.ExtensionMethods;
using PokemonStatCalculator.Utils.Monads.Results;

namespace PokemonStatCalculator.Entities.Train.Stats
{
    public class SpeedStatTrainingStrategy : IStatTrainingStrategy
    {
        // This training strategy uses the formula defined since the third generation of Pokémon.
        public Result<Stat> ApplyStatTrainingTo(Pokemon pokemon, Training training, IStatTrainingChecker statTrainingChecker)
        {
            int spdBaseStatValue = pokemon.BaseStats.GetBaseStatValue(PokemonStat.Speed);

            int spdIndividualValue = training.IndividualValues.GetIndividualValue(PokemonStat.Speed);

            int spdEffortValue = training.EffortValues.GetEffortValue(PokemonStat.Speed);

            int currentLevel = training.Level.CurrentLevel;

            decimal natureValue = training.Nature.GetStatValueChangeTo(PokemonStat.Speed);

            int trainedSpdValue = ApplySpeedStatFormula(spdBaseStatValue, spdIndividualValue, spdEffortValue, currentLevel, natureValue);

            return statTrainingChecker.CheckIfTrainingIsAcceptedFor(trainedSpdValue, PokemonStat.Speed, training, pokemon)
                ? Result.Success<Stat>(new SpeedStat(trainedSpdValue))
                : Result.Fail<Stat>($"The calculated {PokemonStat.Speed.GetDescription()} stat is out of the acceptable range.");
        }

        private int ApplySpeedStatFormula(int spdBaseStatValue, int spdIndividualValue, int spdEffortValue, int currentLevel, decimal natureValue)
        {
            return (int)Math.Floor(((((2 * spdBaseStatValue) + spdIndividualValue + (spdEffortValue / 4)) * currentLevel / 100) + 5) * natureValue);
        }
    }
}