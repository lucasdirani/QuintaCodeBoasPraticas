using System.Collections.Generic;
using PokemonStatCalculator.Entities.Battles;
using PokemonStatCalculator.Entities.Moves.MoveEffects;
using PokemonStatCalculator.Entities.Moves.MoveEffects.PowerUp;
using PokemonStatCalculator.Entities.Others;
using PokemonStatCalculator.Entities.Terrains;
using PokemonStatCalculator.Entities.Types;

namespace PokemonStatCalculator.Entities.Moves
{
    public sealed class RisingVoltageMove : Move
    {
        public override PokemonMove MoveName { get; protected set; } = PokemonMove.RisingVoltage;

        public override PokemonType MoveType { get; protected set; } = PokemonType.Electric;

        public override MoveCategory MoveCategory { get; protected set; } = MoveCategory.Special;

        public override int MovePower { get; protected set; } = 70;

        public override int MovePP { get; protected set; } = 20;

        public override int MovePriority { get; protected set; } = 0;

        public override Percentage MoveAccuracy { get; protected set; } = new Percentage(value: 1.0m);

        public override IEnumerable<MoveEffect> MoveEffects { get; protected set; } = GetRisingVoltageMoveEffects();

        public override MoveUsageType MoveUsageType { get; protected set; } = MoveUsageType.None;

        private static IEnumerable<MoveEffect> GetRisingVoltageMoveEffects()
        {
            return new List<MoveEffect>
            {
                new TerrainPowerUpMoveEffect(
                    poweredUpOnTerrain: TerrainType.Electric,
                    increasedBasePower: new Percentage(value: 1.0m),
                    affectedBattleParticipants: new List<BattleParticipant> { BattleParticipant.User }),
            };
        }
    }
}