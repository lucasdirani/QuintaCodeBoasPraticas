using System.Collections.Generic;
using PokemonStatCalculator.Entities.Battles;
using PokemonStatCalculator.Entities.Others;

namespace PokemonStatCalculator.Entities.Abilities.AbilityEffects.Contact
{
    public sealed class RaiseMovePowerOnContactAbilityEffect : ContactAbilityEffect
    {
        public RaiseMovePowerOnContactAbilityEffect(
            Percentage raiseUserMovePowerPercentage,
            IEnumerable<BattleParticipant> affectedBattleParticipants)
            : base(affectedBattleParticipants)
        {
            RaiseUserMovePowerPercentage = raiseUserMovePowerPercentage;
        }

        public override AbilityEffectType AbilityEffectType { get; protected set; } = AbilityEffectType.RaiseMovePowerOnContact;

        public Percentage RaiseUserMovePowerPercentage { get; private set; }
    }
}