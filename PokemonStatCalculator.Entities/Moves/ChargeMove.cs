using System.Collections.Generic;
using PokemonStatCalculator.Entities.Battles;
using PokemonStatCalculator.Entities.Moves.MoveEffects;
using PokemonStatCalculator.Entities.Moves.MoveEffects.PowerUp;
using PokemonStatCalculator.Entities.Moves.MoveEffects.Stats;
using PokemonStatCalculator.Entities.Others;
using PokemonStatCalculator.Entities.Stats;
using PokemonStatCalculator.Entities.Types;

namespace PokemonStatCalculator.Entities.Moves
{
    public sealed class ChargeMove : Move
    {
        public override PokemonMove MoveName { get; protected set; } = PokemonMove.Charge;

        public override PokemonType MoveType { get; protected set; } = PokemonType.Electric;

        public override MoveCategory MoveCategory { get; protected set; } = MoveCategory.NonDamaging;

        public override int MovePower { get; protected set; } = 0;

        public override int MovePP { get; protected set; } = 20;

        public override int MovePriority { get; protected set; } = 0;

        public override Percentage MoveAccuracy { get; protected set; } = new Percentage(value: 1.0m);

        public override IEnumerable<MoveEffect> MoveEffects { get; protected set; } = GetChargeMoveEffects();

        public override MoveUsageType MoveUsageType { get; protected set; } = MoveUsageType.None;

        private static IEnumerable<MoveEffect> GetChargeMoveEffects()
        {
            return new List<MoveEffect>
            {
                new RaiseStatModificationMoveEffect(
                    raisedStat: PokemonStat.SpecialDefense,
                    raisedStatStages: new Stage(numberOfStages: 1),
                    chanceToRaiseStat: new Percentage(value: 1.0m),
                    affectedBattleParticipants: new List<BattleParticipant> { BattleParticipant.User }),
                new TypePowerUpMoveEffect(
                    poweredUpMoveTypes: new List<PokemonType> { PokemonType.Electric },
                    powerUpOnlyInTheNextTurn: true,
                    increasedBasePower: new Percentage(value: 1.0m),
                    affectedBattleParticipants: new List<BattleParticipant> { BattleParticipant.User }),
            };
        }
    }
}