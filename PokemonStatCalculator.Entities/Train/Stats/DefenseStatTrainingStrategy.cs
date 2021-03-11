using System;
using PokemonStatCalculator.Entities.Pokemons;
using PokemonStatCalculator.Entities.Stats;
using PokemonStatCalculator.Utils.ExtensionMethods;
using PokemonStatCalculator.Utils.Monads.Results;

namespace PokemonStatCalculator.Entities.Train.Stats
{
    public class DefenseStatTrainingStrategy : IStatTrainingStrategy
    {
        // This training strategy uses the formula defined since the third generation of Pokémon.
        public Result<Stat> ApplyStatTrainingTo(Pokemon pokemon, Training training, IStatTrainingChecker statTrainingChecker)
        {
            int defBaseStatValue = pokemon.BaseStats.GetBaseStatValue(PokemonStat.Defense);

            int defIndividualValue = training.IndividualValues.GetIndividualValue(PokemonStat.Defense);

            int defEffortValue = training.EffortValues.GetEffortValue(PokemonStat.Defense);

            int currentLevel = training.Level.CurrentLevel;

            decimal natureValue = training.Nature.GetStatValueChangeTo(PokemonStat.Defense);

            int trainedDefValue = ApplyDefenseStatFormula(defBaseStatValue, defIndividualValue, defEffortValue, currentLevel, natureValue);

            return statTrainingChecker.CheckIfTrainingIsAcceptedFor(trainedDefValue, PokemonStat.Defense, training, pokemon)
                ? Result.Success<Stat>(new DefenseStat(trainedDefValue))
                : Result.Fail<Stat>($"The calculated {PokemonStat.Defense.GetDescription()} stat is out of the acceptable range.");
        }

        private int ApplyDefenseStatFormula(int defBaseStatValue, int defIndividualValue, int defEffortValue, int currentLevel, decimal natureValue)
        {
            return (int)Math.Floor(((((2 * defBaseStatValue) + defIndividualValue + (defEffortValue / 4)) * currentLevel / 100) + 5) * natureValue);
        }
    }
}