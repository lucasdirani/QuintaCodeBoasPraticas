using System.Collections.Generic;
using System.Linq;
using PokemonStatCalculator.Entities.Abilities.AbilityEffects;
using PokemonStatCalculator.Entities.Abilities.AbilityEffects.Stats;
using PokemonStatCalculator.Entities.Battles;
using PokemonStatCalculator.Entities.Stats;
using PokemonStatCalculator.Entities.Types;

namespace PokemonStatCalculator.Entities.Abilities
{
    public sealed class JustifiedAbility : Ability
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
                new DamageOfTypeStatIncreasingAbilityEffect(
                    damageTypesThatActivesStatIncreasing: new List<PokemonType> { PokemonType.Dark, },
                    increasingStats: new List<PokemonStat> { PokemonStat.Attack, },
                    increasingStatsStage: new Stage(1),
                    affectedBattleParticipants: new List<BattleParticipant> { BattleParticipant.User }),
            };
        }

        public override PokemonAbility GetPokemonAbility()
        {
            return PokemonAbility.Justified;
        }

        protected override IEnumerable<PokemonAbility> GetImmunyAbilities()
        {
            return Enumerable.Empty<PokemonAbility>();
        }
    }
}