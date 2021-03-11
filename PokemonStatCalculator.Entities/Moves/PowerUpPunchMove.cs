using System.Collections.Generic;
using PokemonStatCalculator.Entities.Battles;
using PokemonStatCalculator.Entities.Moves.MoveEffects;
using PokemonStatCalculator.Entities.Moves.MoveEffects.Stats;
using PokemonStatCalculator.Entities.Others;
using PokemonStatCalculator.Entities.Stats;
using PokemonStatCalculator.Entities.Types;

namespace PokemonStatCalculator.Entities.Moves
{
    public sealed class PowerUpPunchMove : Move
    {
        public override PokemonMove MoveName { get; protected set; } = PokemonMove.PowerUpPunch;

        public override PokemonType MoveType { get; protected set; } = PokemonType.Fighting;

        public override MoveCategory MoveCategory { get; protected set; } = MoveCategory.Physical;

        public override int MovePower { get; protected set; } = 40;

        public override int MovePP { get; protected set; } = 20;

        public override int MovePriority { get; protected set; } = 0;

        public override Percentage MoveAccuracy { get; protected set; } = new Percentage(value: 1.0m);

        public override IEnumerable<MoveEffect> MoveEffects { get; protected set; } = GetPowerUpPunchMoveEffects();

        public override MoveUsageType MoveUsageType { get; protected set; } = MoveUsageType.Punching;

        private static IEnumerable<MoveEffect> GetPowerUpPunchMoveEffects()
        {
            return new List<MoveEffect>
            {
                new RaiseStatModificationMoveEffect(
                    raisedStat: PokemonStat.Attack,
                    raisedStatStages: new Stage(numberOfStages: 1),
                    chanceToRaiseStat: new Percentage(value: 1.0m),
                    affectedBattleParticipants: new List<BattleParticipant> { BattleParticipant.User }),
            };
        }
    }
}