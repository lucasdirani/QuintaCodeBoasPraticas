using System;
using PokemonStatCalculator.Entities.Pokemons;
using PokemonStatCalculator.Entities.Stats;
using PokemonStatCalculator.Utils.ExtensionMethods;
using PokemonStatCalculator.Utils.Monads.Results;

namespace PokemonStatCalculator.Entities.Train.Stats
{
    public class SpecialAttackStatTrainingStrategy : IStatTrainingStrategy
    {
        // This training strategy uses the formula defined since the third generation of Pokémon.
        public Result<Stat> ApplyStatTrainingTo(Pokemon pokemon, Training training, IStatTrainingChecker statTrainingChecker)
        {
            int spAtkBaseStatValue = pokemon.BaseStats.GetBaseStatValue(PokemonStat.SpecialAttack);

            int spAtkIndividualValue = training.IndividualValues.GetIndividualValue(PokemonStat.SpecialAttack);

            int spAtkEffortValue = training.EffortValues.GetEffortValue(PokemonStat.SpecialAttack);

            int currentLevel = training.Level.CurrentLevel;

            decimal natureValue = training.Nature.GetStatValueChangeTo(PokemonStat.SpecialAttack);

            int trainedSpAtkValue = ApplySpecialAttackStatFormula(spAtkBaseStatValue, spAtkIndividualValue, spAtkEffortValue, currentLevel, natureValue);

            return statTrainingChecker.CheckIfTrainingIsAcceptedFor(trainedSpAtkValue, PokemonStat.SpecialAttack, training, pokemon)
                ? Result.Success<Stat>(new SpecialAttackStat(trainedSpAtkValue))
                : Result.Fail<Stat>($"The calculated {PokemonStat.SpecialAttack.GetDescription()} stat is out of the acceptable range.");
        }

        private int ApplySpecialAttackStatFormula(int spAtkBaseStatValue, int spAtkIndividualValue, int spAtkEffortValue, int currentLevel, decimal natureValue)
        {
            return (int)Math.Floor(((((2 * spAtkBaseStatValue) + spAtkIndividualValue + (spAtkEffortValue / 4)) * currentLevel / 100) + 5) * natureValue);
        }
    }
}