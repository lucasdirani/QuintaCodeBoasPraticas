using System.Collections.Generic;
using PokemonStatCalculator.Entities.Battles;
using PokemonStatCalculator.Entities.Types;

namespace PokemonStatCalculator.Entities.Moves.MoveEffects.Type
{
    public sealed class MoveChangeTypeMoveEffect : ChangeTypeMoveEffect
    {
        public MoveChangeTypeMoveEffect(
            IEnumerable<PokemonType> affectedMoveTypes,
            IEnumerable<PokemonType> possibleNewTypesToMove,
            IEnumerable<BattleParticipant> affectedBattleParticipants)
            : base(affectedMoveTypes, possibleNewTypesToMove, affectedBattleParticipants)
        {
            AffectedMoveTypes = affectedMoveTypes;
            PossibleNewTypesToMove = possibleNewTypesToMove;
        }

        public override MoveEffectType MoveEffectType { get; protected set; } = MoveEffectType.MoveChangeType;
    }
}