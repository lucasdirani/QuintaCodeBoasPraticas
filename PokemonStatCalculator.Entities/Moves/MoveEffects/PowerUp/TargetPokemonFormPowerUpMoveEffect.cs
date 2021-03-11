using System.Collections.Generic;
using PokemonStatCalculator.Entities.Battles;
using PokemonStatCalculator.Entities.Others;
using PokemonStatCalculator.Entities.Pokemons;

namespace PokemonStatCalculator.Entities.Moves.MoveEffects.PowerUp
{
    public sealed class TargetPokemonFormPowerUpMoveEffect : PowerUpMoveEffect
    {
        public TargetPokemonFormPowerUpMoveEffect(
            IEnumerable<PokemonForm> targetedPokemonFormsThatPowerUpMove,
            Percentage increasedBasePower,
            IEnumerable<BattleParticipant> affectedBattleParticipants)
            : base(increasedBasePower, affectedBattleParticipants)
        {
            TargetedPokemonFormsThatPowerUpMove = targetedPokemonFormsThatPowerUpMove;
        }

        public override MoveEffectType MoveEffectType { get; protected set; } = MoveEffectType.TargetPokemonFormPowerUp;

        public IEnumerable<PokemonForm> TargetedPokemonFormsThatPowerUpMove { get; private set; }
    }
}