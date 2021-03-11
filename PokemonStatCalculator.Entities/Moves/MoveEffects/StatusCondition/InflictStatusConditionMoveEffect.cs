using System.Collections.Generic;
using PokemonStatCalculator.Entities.Battles;
using PokemonStatCalculator.Entities.Others;
using PokemonStatCalculator.Entities.StatusConditions;

namespace PokemonStatCalculator.Entities.Moves.MoveEffects.StatusCondition
{
    public sealed class InflictStatusConditionMoveEffect : MoveEffect
    {
        public InflictStatusConditionMoveEffect(
            StatusConditionType inflictedStatusCondition,
            Percentage chanceToInflictStatusCondition,
            IEnumerable<BattleParticipant> affectedBattleParticipants)
            : base(affectedBattleParticipants)
        {
            InflictedStatusCondition = inflictedStatusCondition;
            ChanceToInflictStatusCondition = chanceToInflictStatusCondition;
        }

        public override MoveEffectType MoveEffectType { get; protected set; } = MoveEffectType.InflictStatusCondition;

        public StatusConditionType InflictedStatusCondition { get; private set; }

        public Percentage ChanceToInflictStatusCondition { get; private set; }
    }
}