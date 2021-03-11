using System.Collections.Generic;
using PokemonStatCalculator.Entities.Battles;
using PokemonStatCalculator.Entities.Others;

namespace PokemonStatCalculator.Entities.Abilities.AbilityEffects.Contact
{
    public sealed class DecreaseHPOnContactAbilityEffect : ContactAbilityEffect
    {
        public DecreaseHPOnContactAbilityEffect(
            Percentage decreaseHPPercentage,
            IEnumerable<BattleParticipant> affectedBattleParticipants)
            : base(affectedBattleParticipants)
        {
            DecreaseHPPercentage = decreaseHPPercentage;
        }

        public override AbilityEffectType AbilityEffectType { get; protected set; } = AbilityEffectType.DecreaseHPOnContact;

        public Percentage DecreaseHPPercentage { get; private set; }
    }
}