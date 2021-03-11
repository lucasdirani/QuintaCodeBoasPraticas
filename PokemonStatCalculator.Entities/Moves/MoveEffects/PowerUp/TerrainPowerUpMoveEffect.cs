using System.Collections.Generic;
using PokemonStatCalculator.Entities.Battles;
using PokemonStatCalculator.Entities.Others;
using PokemonStatCalculator.Entities.Terrains;

namespace PokemonStatCalculator.Entities.Moves.MoveEffects.PowerUp
{
    public sealed class TerrainPowerUpMoveEffect : PowerUpMoveEffect
    {
        public TerrainPowerUpMoveEffect(
            TerrainType poweredUpOnTerrain,
            Percentage increasedBasePower,
            IEnumerable<BattleParticipant> affectedBattleParticipants)
            : base(increasedBasePower, affectedBattleParticipants)
        {
            PoweredUpOnTerrain = poweredUpOnTerrain;
        }

        public override MoveEffectType MoveEffectType { get; protected set; } = MoveEffectType.TerrainPowerUp;

        public TerrainType PoweredUpOnTerrain { get; private set; }
    }
}