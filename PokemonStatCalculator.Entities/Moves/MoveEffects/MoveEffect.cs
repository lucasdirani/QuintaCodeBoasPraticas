using System.Collections.Generic;
using PokemonStatCalculator.Entities.Battles;

namespace PokemonStatCalculator.Entities.Moves.MoveEffects
{
    public abstract class MoveEffect
    {
        protected MoveEffect(IEnumerable<BattleParticipant> affectedBattleParticipants)
        {
            AffectedBattleParticipants = affectedBattleParticipants;
        }

        public abstract MoveEffectType MoveEffectType { get; protected set; }

        public IEnumerable<BattleParticipant> AffectedBattleParticipants { get; protected set; }
    }
}