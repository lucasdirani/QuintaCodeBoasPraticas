using System.Collections.Generic;
using PokemonStatCalculator.Entities.Battles;

namespace PokemonStatCalculator.Entities.Moves.MoveEffects.Priority
{
    public abstract class PriorityMoveEffect : MoveEffect
    {
        protected PriorityMoveEffect(int priorityNumber, IEnumerable<BattleParticipant> affectedBattleParticipants)
            : base(affectedBattleParticipants)
        {
            PriorityNumber = priorityNumber;
        }

        public int PriorityNumber { get; protected set; }
    }
}