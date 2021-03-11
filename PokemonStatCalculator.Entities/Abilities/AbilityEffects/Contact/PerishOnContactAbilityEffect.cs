using System.Collections.Generic;
using PokemonStatCalculator.Entities.Battles;

namespace PokemonStatCalculator.Entities.Abilities.AbilityEffects.Contact
{
    public sealed class PerishOnContactAbilityEffect : ContactAbilityEffect
    {
        public PerishOnContactAbilityEffect(
            int numberOfTurnsToPerish,
            IEnumerable<BattleParticipant> affectedBattleParticipants)
            : base(affectedBattleParticipants)
        {
            NumberOfTurnsToPerish = numberOfTurnsToPerish;
        }

        public override AbilityEffectType AbilityEffectType { get; protected set; } = AbilityEffectType.PerishOnContact;

        public int NumberOfTurnsToPerish { get; private set; }
    }
}