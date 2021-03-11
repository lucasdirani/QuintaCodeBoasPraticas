using System.Collections.Generic;
using PokemonStatCalculator.Entities.Battles;

namespace PokemonStatCalculator.Entities.Moves.MoveEffects.Weight
{
    public sealed class WeightChangeMoveEffect : MoveEffect
    {
        public WeightChangeMoveEffect(double appliedWeight, IEnumerable<BattleParticipant> affectedBattleParticipants)
            : base(affectedBattleParticipants)
        {
            AppliedWeight = appliedWeight;
        }

        public override MoveEffectType MoveEffectType { get; protected set; } = MoveEffectType.WeightChange;

        public double AppliedWeight { get; private set; }
    }
}