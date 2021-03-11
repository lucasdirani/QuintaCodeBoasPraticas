using System.Collections.Generic;
using PokemonStatCalculator.Entities.Battles;
using PokemonStatCalculator.Entities.EntryHazards;

namespace PokemonStatCalculator.Entities.Moves.MoveEffects.EntryHazard
{
    public sealed class RemovingEntryHazardMoveEffect : MoveEffect
    {
        public RemovingEntryHazardMoveEffect(
            IEnumerable<EntryHazardType> removedEntryHazards,
            IEnumerable<BattleParticipant> affectedBattleParticipants)
            : base(affectedBattleParticipants)
        {
            RemovedEntryHazards = removedEntryHazards;
        }

        public override MoveEffectType MoveEffectType { get; protected set; } = MoveEffectType.RemovingEntryHazard;

        public IEnumerable<EntryHazardType> RemovedEntryHazards { get; private set; }
    }
}