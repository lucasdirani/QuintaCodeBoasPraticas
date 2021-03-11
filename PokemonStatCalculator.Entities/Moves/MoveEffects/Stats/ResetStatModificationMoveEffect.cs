using System.Collections.Generic;
using PokemonStatCalculator.Entities.Battles;
using PokemonStatCalculator.Entities.Others;
using PokemonStatCalculator.Entities.Stats;

namespace PokemonStatCalculator.Entities.Moves.MoveEffects.Stats
{
    public sealed class ResetStatModificationMoveEffect : StatModificationMoveEffect
    {
        public ResetStatModificationMoveEffect(
            PokemonStat resetedStat,
            Stage resetStatStages,
            Percentage chanceToResetStat,
            IEnumerable<BattleParticipant> affectedBattleParticipants)
            : base(resetedStat, resetStatStages, chanceToResetStat, affectedBattleParticipants)
        {
        }

        public override MoveEffectType MoveEffectType { get; protected set; } = MoveEffectType.ResetStatModification;
    }
}