using System.Collections.Generic;
using PokemonStatCalculator.Entities.Battles;
using PokemonStatCalculator.Entities.Others;

namespace PokemonStatCalculator.Entities.Moves.MoveEffects.Bind
{
    public sealed class BindingMoveEffect : MoveEffect
    {
        public BindingMoveEffect(
            int minimumNumberOfTurnsTrapped,
            int maximumNumberOfTurnsTrapped,
            IDictionary<int, Percentage> percentNumberOfTurnsToAttack,
            Percentage percentOfDamageDone,
            IEnumerable<BattleParticipant> affectedBattleParticipants)
            : base(affectedBattleParticipants)
        {
            MinimumNumberOfTurnsTrapped = minimumNumberOfTurnsTrapped;
            MaximumNumberOfTurnsTrapped = maximumNumberOfTurnsTrapped;
            PercentNumberOfTurnsToAttack = percentNumberOfTurnsToAttack;
            PercentOfDamageDone = percentOfDamageDone;
        }

        public override MoveEffectType MoveEffectType { get; protected set; } = MoveEffectType.Binding;

        public int MinimumNumberOfTurnsTrapped { get; private set; }

        public int MaximumNumberOfTurnsTrapped { get; private set; }

        public IDictionary<int, Percentage> PercentNumberOfTurnsToAttack { get; private set; }

        public Percentage PercentOfDamageDone { get; private set; }
    }
}