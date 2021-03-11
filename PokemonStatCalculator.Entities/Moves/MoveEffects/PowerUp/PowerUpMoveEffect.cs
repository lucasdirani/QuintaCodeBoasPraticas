using System.Collections.Generic;
using PokemonStatCalculator.Entities.Battles;
using PokemonStatCalculator.Entities.Others;

namespace PokemonStatCalculator.Entities.Moves.MoveEffects.PowerUp
{
    public abstract class PowerUpMoveEffect : MoveEffect
    {
        protected PowerUpMoveEffect(
            Percentage increasedBasePower,
            IEnumerable<BattleParticipant> affectedBattleParticipants)
            : base(affectedBattleParticipants)
        {
            IncreasedBasePower = increasedBasePower;
        }

        public Percentage IncreasedBasePower { get; protected set; }
    }
}