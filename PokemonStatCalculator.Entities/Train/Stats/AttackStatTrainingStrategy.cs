using System;
using PokemonStatCalculator.Entities.Pokemons;
using PokemonStatCalculator.Entities.Stats;
using PokemonStatCalculator.Utils.ExtensionMethods;
using PokemonStatCalculator.Utils.Monads.Results;

namespace PokemonStatCalculator.Entities.Train.Stats
{
    public class AttackStatTrainingStrategy : IStatTrainingStrategy
    {
        // This training strategy uses the formula defined since the third generation of Pokémon.
        public Result<Stat> ApplyStatTrainingTo(Pokemon pokemon, Training training, IStatTrainingChecker statTrainingChecker)
        {
            int atkBaseStatValue = pokemon.BaseStats.GetBaseStatValue(PokemonStat.Attack);

            int atkIndividualValue = training.IndividualValues.GetIndividualValue(PokemonStat.Attack);

            int atkEffortValue = training.EffortValues.GetEffortValue(PokemonStat.Attack);

            int currentLevel = training.Level.CurrentLevel;

            decimal natureValue = training.Nature.GetStatValueChangeTo(PokemonStat.Attack);

            int trainedAtkValue = ApplyAttackStatFormula(atkBaseStatValue, atkIndividualValue, atkEffortValue, currentLevel, natureValue);

            return statTrainingChecker.CheckIfTrainingIsAcceptedFor(trainedAtkValue, PokemonStat.Attack, training, pokemon)
                ? Result.Success<Stat>(new AttackStat(trainedAtkValue))
                : Result.Fail<Stat>($"The calculated {PokemonStat.Attack.GetDescription()} stat is out of the acceptable range.");
        }

        private int ApplyAttackStatFormula(int atkBaseStatValue, int atkIndividualValue, int atkEffortValue, int currentLevel, decimal natureValue)
        {
            return (int)Math.Floor(((((2 * atkBaseStatValue) + atkIndividualValue + (atkEffortValue / 4)) * currentLevel / 100) + 5) * natureValue);
        }
    }
}