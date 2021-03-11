using System.Collections.Generic;
using PokemonStatCalculator.Entities.Battles;
using PokemonStatCalculator.Entities.Others;
using PokemonStatCalculator.Entities.Types;

namespace PokemonStatCalculator.Entities.Moves.MoveEffects.PowerUp
{
    public sealed class TypePowerUpMoveEffect : PowerUpMoveEffect
    {
        public TypePowerUpMoveEffect(
            IEnumerable<PokemonType> poweredUpMoveTypes,
            bool powerUpOnlyInTheNextTurn,
            Percentage increasedBasePower,
            IEnumerable<BattleParticipant> affectedBattleParticipants)
            : base(increasedBasePower, affectedBattleParticipants)
        {
            PoweredUpMoveTypes = poweredUpMoveTypes;
            PowerUpOnlyInTheNextTurn = powerUpOnlyInTheNextTurn;
        }

        public override MoveEffectType MoveEffectType { get; protected set; } = MoveEffectType.TypePowerUp;

        public IEnumerable<PokemonType> PoweredUpMoveTypes { get; private set; }

        public bool PowerUpOnlyInTheNextTurn { get; private set; }
    }
}