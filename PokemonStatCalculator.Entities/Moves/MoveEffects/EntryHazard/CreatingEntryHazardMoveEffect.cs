using System.Collections.Generic;
using PokemonStatCalculator.Entities.Battles;
using PokemonStatCalculator.Entities.Others;
using PokemonStatCalculator.Entities.Stats;
using PokemonStatCalculator.Entities.StatusConditions;

namespace PokemonStatCalculator.Entities.Moves.MoveEffects.EntryHazard
{
    public sealed class CreatingEntryHazardMoveEffect : MoveEffect
    {
        public CreatingEntryHazardMoveEffect(
            Percentage entryHazardDamage,
            int maximumNumberOfEntryHazards,
            IEnumerable<PokemonStat> decreasedStatsByEntryHazard,
            IEnumerable<StatusConditionType> causedStatusConditionsByEntryHazard,
            IEnumerable<BattleParticipant> affectedBattleParticipants)
            : base(affectedBattleParticipants)
        {
            EntryHazardDamage = entryHazardDamage;
            MaximumNumberOfEntryHazards = maximumNumberOfEntryHazards;
            DecreasedStatsByEntryHazard = decreasedStatsByEntryHazard;
            CausedStatusConditionsByEntryHazard = causedStatusConditionsByEntryHazard;
        }

        public override MoveEffectType MoveEffectType { get; protected set; } = MoveEffectType.CreatingEntryHazard;

        public Percentage EntryHazardDamage { get; private set; }

        public int MaximumNumberOfEntryHazards { get; private set; }

        public IEnumerable<PokemonStat> DecreasedStatsByEntryHazard { get; private set; }

        public IEnumerable<StatusConditionType> CausedStatusConditionsByEntryHazard { get; private set; }
    }
}