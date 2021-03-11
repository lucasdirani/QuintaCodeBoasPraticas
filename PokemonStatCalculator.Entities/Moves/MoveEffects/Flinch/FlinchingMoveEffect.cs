using System.Collections.Generic;
using PokemonStatCalculator.Entities.Battles;
using PokemonStatCalculator.Entities.Others;

namespace PokemonStatCalculator.Entities.Moves.MoveEffects.Flinch
{
    public sealed class FlinchingMoveEffect : MoveEffect
    {
        public FlinchingMoveEffect(
            Percentage chanceOfCauseFlinching,
            IEnumerable<BattleParticipant> affectedBattleParticipants)
            : base(affectedBattleParticipants)
        {
            ChanceOfCauseFlinching = chanceOfCauseFlinching;
        }

        public override MoveEffectType MoveEffectType { get; protected set; } = MoveEffectType.Flinching;

        public Percentage ChanceOfCauseFlinching { get; private set; }
    }
}