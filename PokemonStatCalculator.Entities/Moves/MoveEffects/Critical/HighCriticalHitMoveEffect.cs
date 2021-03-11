using System.Collections.Generic;
using PokemonStatCalculator.Entities.Battles;
using PokemonStatCalculator.Entities.Others;

namespace PokemonStatCalculator.Entities.Moves.MoveEffects.Critical
{
    public sealed class HighCriticalHitMoveEffect : MoveEffect
    {
        public HighCriticalHitMoveEffect(
            Percentage chanceToCriticalHit,
            IEnumerable<BattleParticipant> affectedBattleParticipants)
            : base(affectedBattleParticipants)
        {
            ChanceToCriticalHit = chanceToCriticalHit;
        }

        public override MoveEffectType MoveEffectType { get; protected set; } = MoveEffectType.HighCriticalHit;

        public Percentage ChanceToCriticalHit { get; private set; }
    }
}