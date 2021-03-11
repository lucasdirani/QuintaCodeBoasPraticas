using System.Collections.Generic;
using PokemonStatCalculator.Entities.Battles;
using PokemonStatCalculator.Entities.Others;
using PokemonStatCalculator.Entities.Stats;

namespace PokemonStatCalculator.Entities.Moves.MoveEffects.Stats
{
    public sealed class LowerStatModificationMoveEffect : StatModificationMoveEffect
    {
        public LowerStatModificationMoveEffect(
            PokemonStat loweredStat,
            Stage loweredStatStages,
            Percentage chanceToLowerStat,
            IEnumerable<BattleParticipant> affectedBattleParticipants)
            : base(loweredStat, loweredStatStages, chanceToLowerStat, affectedBattleParticipants)
        {
        }

        public override MoveEffectType MoveEffectType { get; protected set; } = MoveEffectType.LowerStatModification;
    }
}