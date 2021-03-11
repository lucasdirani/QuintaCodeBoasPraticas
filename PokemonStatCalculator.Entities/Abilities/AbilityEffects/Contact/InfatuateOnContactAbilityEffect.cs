using System.Collections.Generic;
using PokemonStatCalculator.Entities.Battles;
using PokemonStatCalculator.Entities.Others;

namespace PokemonStatCalculator.Entities.Abilities.AbilityEffects.Contact
{
    public sealed class InfatuateOnContactAbilityEffect : ContactAbilityEffect
    {
        public InfatuateOnContactAbilityEffect(
            Percentage infatuatePercentage,
            IEnumerable<BattleParticipant> affectedBattleParticipants)
            : base(affectedBattleParticipants)
        {
            InfatuatePercentage = infatuatePercentage;
        }

        public override AbilityEffectType AbilityEffectType { get; protected set; } = AbilityEffectType.InfatuateOnContact;

        public Percentage InfatuatePercentage { get; private set; }
    }
}