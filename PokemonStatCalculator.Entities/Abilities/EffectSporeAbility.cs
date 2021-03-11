using System.Collections.Generic;
using System.Linq;
using PokemonStatCalculator.Entities.Abilities.AbilityEffects;
using PokemonStatCalculator.Entities.Abilities.AbilityEffects.Contact;
using PokemonStatCalculator.Entities.Battles;
using PokemonStatCalculator.Entities.Others;
using PokemonStatCalculator.Entities.StatusConditions;

namespace PokemonStatCalculator.Entities.Abilities
{
    public sealed class EffectSporeAbility : Ability
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
                new CauseStatusConditionOnContactAbilityEffect(
                    possibleCausedStatusConditions: new List<StatusConditionType>
                    {
                        StatusConditionType.Sleep,
                        StatusConditionType.Paralyzed,
                        StatusConditionType.Poison,
                    },
                    causeStatusConditionPercentage: new Percentage(0.3m),
                    affectedBattleParticipants: new List<BattleParticipant> { BattleParticipant.Target }),
            };
        }

        public override PokemonAbility GetPokemonAbility()
        {
            return PokemonAbility.EffectSpore;
        }

        protected override IEnumerable<PokemonAbility> GetImmunyAbilities()
        {
            return Enumerable.Empty<PokemonAbility>();
        }
    }
}