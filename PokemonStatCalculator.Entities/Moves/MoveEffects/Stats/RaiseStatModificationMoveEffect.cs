using System.Collections.Generic;
using PokemonStatCalculator.Entities.Battles;
using PokemonStatCalculator.Entities.Others;
using PokemonStatCalculator.Entities.Stats;

namespace PokemonStatCalculator.Entities.Moves.MoveEffects.Stats
{
    public sealed class RaiseStatModificationMoveEffect : StatModificationMoveEffect
    {
        public RaiseStatModificationMoveEffect(
            PokemonStat raisedStat,
            Stage raisedStatStages,
            Percentage chanceToRaiseStat,
            IEnumerable<BattleParticipant> affectedBattleParticipants)
            : base(raisedStat, raisedStatStages, chanceToRaiseStat, affectedBattleParticipants)
        {
        }

        public override MoveEffectType MoveEffectType { get; protected set; } = MoveEffectType.RaiseStatModification;
    }
}