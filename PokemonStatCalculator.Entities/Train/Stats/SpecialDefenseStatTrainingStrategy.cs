using System;
using PokemonStatCalculator.Entities.Pokemons;
using PokemonStatCalculator.Entities.Stats;
using PokemonStatCalculator.Utils.ExtensionMethods;
using PokemonStatCalculator.Utils.Monads.Results;

namespace PokemonStatCalculator.Entities.Train.Stats
{
    public class SpecialDefenseStatTrainingStrategy : IStatTrainingStrategy
    {
        // This training strategy uses the formula defined since the third generation of Pokémon.
        public Result<Stat> ApplyStatTrainingTo(Pokemon pokemon, Training training, IStatTrainingChecker statTrainingChecker)
        {
            int spDefBaseStatValue = pokemon.BaseStats.GetBaseStatValue(PokemonStat.SpecialDefense);

            int spDefIndividualValue = training.IndividualValues.GetIndividualValue(PokemonStat.SpecialDefense);

            int spDefEffortValue = training.EffortValues.GetEffortValue(PokemonStat.SpecialDefense);

            int currentLevel = training.Level.CurrentLevel;

            decimal natureValue = training.Nature.GetStatValueChangeTo(PokemonStat.SpecialDefense);

            int trainedSpDefValue = ApplySpecialDefenseStatFormula(spDefBaseStatValue, spDefIndividualValue, spDefEffortValue, currentLevel, natureValue);

            return statTrainingChecker.CheckIfTrainingIsAcceptedFor(trainedSpDefValue, PokemonStat.SpecialDefense, training, pokemon)
                ? Result.Success<Stat>(new SpecialDefenseStat(trainedSpDefValue))
                : Result.Fail<Stat>($"The calculated {PokemonStat.SpecialDefense.GetDescription()} stat is out of the acceptable range.");
        }

        private int ApplySpecialDefenseStatFormula(int spDefBaseStatValue, int spDefIndividualValue, int spDefEffortValue, int currentLevel, decimal natureValue)
        {
            return (int)Math.Floor(((((2 * spDefBaseStatValue) + spDefIndividualValue + (spDefEffortValue / 4)) * currentLevel / 100) + 5) * natureValue);
        }
    }
}