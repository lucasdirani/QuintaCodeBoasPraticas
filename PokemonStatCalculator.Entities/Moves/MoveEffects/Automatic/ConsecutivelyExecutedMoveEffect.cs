using System.Collections.Generic;
using PokemonStatCalculator.Entities.Battles;
using PokemonStatCalculator.Entities.Others;

namespace PokemonStatCalculator.Entities.Moves.MoveEffects.Automatic
{
    public sealed class ConsecutivelyExecutedMoveEffect : MoveEffect
    {
        public ConsecutivelyExecutedMoveEffect(
            int minimumNumberOfExecutionTurns,
            int maximumNumberOfExecutionTurns,
            IDictionary<int, Percentage> percentNumberOfTurnsToAttack,
            Percentage percentOfIncreasedDamageDone,
            IEnumerable<BattleParticipant> affectedBattleParticipants)
            : base(affectedBattleParticipants)
        {
            MinimumNumberOfExecutionTurns = minimumNumberOfExecutionTurns;
            MaximumNumberOfExecutionTurns = maximumNumberOfExecutionTurns;
            PercentNumberOfTurnsToAttack = percentNumberOfTurnsToAttack;
            PercentOfIncreasedDamageDone = percentOfIncreasedDamageDone;
        }

        public override MoveEffectType MoveEffectType { get; protected set; } = MoveEffectType.ConsecutivelyExecuted;

        public int MinimumNumberOfExecutionTurns { get; private set; }

        public int MaximumNumberOfExecutionTurns { get; private set; }

        public IDictionary<int, Percentage> PercentNumberOfTurnsToAttack { get; private set; }

        public Percentage PercentOfIncreasedDamageDone { get; private set; }
    }
}