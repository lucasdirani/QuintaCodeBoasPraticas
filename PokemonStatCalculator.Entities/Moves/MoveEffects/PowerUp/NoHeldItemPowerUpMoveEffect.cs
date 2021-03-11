using System.Collections.Generic;
using PokemonStatCalculator.Entities.Battles;
using PokemonStatCalculator.Entities.Others;

namespace PokemonStatCalculator.Entities.Moves.MoveEffects.PowerUp
{
    public sealed class NoHeldItemPowerUpMoveEffect : PowerUpMoveEffect
    {
        public NoHeldItemPowerUpMoveEffect(
            Percentage increasedBasePower,
            IEnumerable<BattleParticipant> affectedBattleParticipants)
            : base(increasedBasePower, affectedBattleParticipants)
        {
            IncreasedBasePower = increasedBasePower;
        }

        public override MoveEffectType MoveEffectType { get; protected set; }
    }
}