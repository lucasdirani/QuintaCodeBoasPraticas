using System.Collections.Generic;
using PokemonStatCalculator.Entities.Battles;
using PokemonStatCalculator.Entities.Others;
using PokemonStatCalculator.Entities.StatusConditions;

namespace PokemonStatCalculator.Entities.Abilities.AbilityEffects.Contact
{
    public sealed class CauseStatusConditionOnContactAbilityEffect : ContactAbilityEffect
    {
        public CauseStatusConditionOnContactAbilityEffect(
            IEnumerable<StatusConditionType> possibleCausedStatusConditions,
            Percentage causeStatusConditionPercentage,
            IEnumerable<BattleParticipant> affectedBattleParticipants)
            : base(affectedBattleParticipants)
        {
            PossibleCausedStatusConditions = possibleCausedStatusConditions;
            CauseStatusConditionPercentage = causeStatusConditionPercentage;
        }

        public override AbilityEffectType AbilityEffectType { get; protected set; } = AbilityEffectType.CauseStatusConditionOnContact;

        public IEnumerable<StatusConditionType> PossibleCausedStatusConditions { get; private set; }

        public Percentage CauseStatusConditionPercentage { get; private set; }
    }
}