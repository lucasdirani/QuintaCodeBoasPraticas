using System.Collections.Generic;
using System.Linq;
using PokemonStatCalculator.Entities.Abilities.AbilityEffects;
using PokemonStatCalculator.Entities.Abilities.AbilityEffects.Stats;
using PokemonStatCalculator.Entities.Battles;
using PokemonStatCalculator.Entities.Others;
using PokemonStatCalculator.Entities.Stats;

namespace PokemonStatCalculator.Entities.Abilities
{
    public sealed class BerserkAbility : Ability
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
                new LostHPStatIncreasingAbilityEffect(
                    lostUserHPPercentageToActivate: new Percentage(0.5m),
                    increasingStats: new List<PokemonStat> { PokemonStat.SpecialAttack, },
                    increasingStatsStage: new Stage(1),
                    affectedBattleParticipants: new List<BattleParticipant> { BattleParticipant.User }),
            };
        }

        public override PokemonAbility GetPokemonAbility()
        {
            return PokemonAbility.Berserk;
        }

        protected override IEnumerable<PokemonAbility> GetImmunyAbilities()
        {
            return Enumerable.Empty<PokemonAbility>();
        }
    }
}