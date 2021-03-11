using System.Collections.Generic;
using System.Linq;
using PokemonStatCalculator.Entities.Abilities.AbilityEffects;
using PokemonStatCalculator.Entities.Abilities.AbilityEffects.Stats;
using PokemonStatCalculator.Entities.Battles;
using PokemonStatCalculator.Entities.Stats;

namespace PokemonStatCalculator.Entities.Abilities
{
    public sealed class CompetitiveAbility : Ability
    {
        public override bool CheckIfAbilityActivatesOnExitingfTheBattle()
        {
            return false;
        }

        public override bool CheckIfAbilityActivatesOnTheBeginningfTheBattle()
        {
            return false;
        }

        public override bool CheckIfAbilityActivatesOnTheEndOfTheTurn()
        {
            return false;
        }

        public override bool CheckIfAbilityCanBeCopied()
        {
            return true;
        }

        public override IEnumerable<AbilityEffect> GetAbilityEffects()
        {
            return new List<AbilityEffect>
            {
                new DecreaseStatUserStatIncreasingAbilityEffect(
                    decreasedStatsThatActivatesStatIncreasing: new List<PokemonStat>
                    {
                        PokemonStat.Attack, PokemonStat.Defense, PokemonStat.SpecialAttack, PokemonStat.SpecialDefense, PokemonStat.Speed,
                    },
                    increasingStats: new List<PokemonStat> { PokemonStat.SpecialAttack },
                    increasingStatsStage: new Stage(2),
                    affectedBattleParticipants: new List<BattleParticipant> { BattleParticipant.User }),
            };
        }

        public override PokemonAbility GetPokemonAbility()
        {
            return PokemonAbility.Competitive;
        }

        protected override IEnumerable<PokemonAbility> GetImmunyAbilities()
        {
            return Enumerable.Empty<PokemonAbility>();
        }
    }
}