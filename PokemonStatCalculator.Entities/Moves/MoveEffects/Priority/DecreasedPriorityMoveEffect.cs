using System.Collections.Generic;
using PokemonStatCalculator.Entities.Battles;

namespace PokemonStatCalculator.Entities.Moves.MoveEffects.Priority
{
    public sealed class DecreasedPriorityMoveEffect : PriorityMoveEffect
    {
        public DecreasedPriorityMoveEffect(
            int priorityNumber,
            IEnumerable<BattleParticipant> affectedBattleParticipants)
            : base(priorityNumber, affectedBattleParticipants)
        {
        }

        public override MoveEffectType MoveEffectType { get; protected set; } = MoveEffectType.DecreasedPriority;
    }
}