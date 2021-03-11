using System.Collections.Generic;
using PokemonStatCalculator.Entities.Battles;
using PokemonStatCalculator.Entities.Types;

namespace PokemonStatCalculator.Entities.Moves.MoveEffects.Type
{
    public abstract class ChangeTypeMoveEffect : MoveEffect
    {
        protected ChangeTypeMoveEffect(
            IEnumerable<PokemonType> affectedMoveTypes,
            IEnumerable<PokemonType> possibleNewTypesToMove,
            IEnumerable<BattleParticipant> affectedBattleParticipants)
            : base(affectedBattleParticipants)
        {
            AffectedMoveTypes = affectedMoveTypes;
            PossibleNewTypesToMove = possibleNewTypesToMove;
        }

        public IEnumerable<PokemonType> AffectedMoveTypes { get; protected set; }

        public IEnumerable<PokemonType> PossibleNewTypesToMove { get; protected set; }
    }
}