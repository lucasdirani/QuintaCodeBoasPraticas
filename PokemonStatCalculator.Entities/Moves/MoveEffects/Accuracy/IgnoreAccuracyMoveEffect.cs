using System.Collections.Generic;
using PokemonStatCalculator.Entities.Battles;
using PokemonStatCalculator.Entities.Others;

namespace PokemonStatCalculator.Entities.Moves.MoveEffects.Accuracy
{
    public sealed class IgnoreAccuracyMoveEffect : MoveEffect
    {
        public IgnoreAccuracyMoveEffect(
            Percentage chanceToIgnoreAccuracy,
            IEnumerable<BattleParticipant> affectedBattleParticipants)
            : base(affectedBattleParticipants)
        {
            ChanceToIgnoreAccuracy = chanceToIgnoreAccuracy;
        }

        public override MoveEffectType MoveEffectType { get; protected set; } = MoveEffectType.IgnoreAccuracy;

        public Percentage ChanceToIgnoreAccuracy { get; private set; }
    }
}