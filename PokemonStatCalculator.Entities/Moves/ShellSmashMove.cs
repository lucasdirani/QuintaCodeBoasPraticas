using System.Collections.Generic;
using PokemonStatCalculator.Entities.Battles;
using PokemonStatCalculator.Entities.Moves.MoveEffects;
using PokemonStatCalculator.Entities.Moves.MoveEffects.Stats;
using PokemonStatCalculator.Entities.Others;
using PokemonStatCalculator.Entities.Stats;
using PokemonStatCalculator.Entities.Types;

namespace PokemonStatCalculator.Entities.Moves
{
    public sealed class ShellSmashMove : Move
    {
        public override PokemonMove MoveName { get; protected set; } = PokemonMove.ShellSmash;

        public override PokemonType MoveType { get; protected set; } = PokemonType.Normal;

        public override MoveCategory MoveCategory { get; protected set; } = MoveCategory.NonDamaging;

        public override int MovePower { get; protected set; } = 0;

        public override int MovePP { get; protected set; } = 15;

        public override int MovePriority { get; protected set; } = 0;

        public override Percentage MoveAccuracy { get; protected set; } = new Percentage(value: 1.0m);

        public override IEnumerable<MoveEffect> MoveEffects { get; protected set; } = GetShellSmashMoveEffects();

        public override MoveUsageType MoveUsageType { get; protected set; } = MoveUsageType.None;

        private static IEnumerable<MoveEffect> GetShellSmashMoveEffects()
        {
            return new List<MoveEffect>
            {
                new RaiseStatModificationMoveEffect(
                    raisedStat: PokemonStat.Attack,
                    raisedStatStages: new Stage(numberOfStages: 2),
                    chanceToRaiseStat: new Percentage(value: 1.0m),
                    affectedBattleParticipants: new List<BattleParticipant> { BattleParticipant.User }),
                new RaiseStatModificationMoveEffect(
                    raisedStat: PokemonStat.SpecialAttack,
                    raisedStatStages: new Stage(numberOfStages: 2),
                    chanceToRaiseStat: new Percentage(value: 1.0m),
                    affectedBattleParticipants: new List<BattleParticipant> { BattleParticipant.User }),
                new RaiseStatModificationMoveEffect(
                    raisedStat: PokemonStat.Speed,
                    raisedStatStages: new Stage(numberOfStages: 2),
                    chanceToRaiseStat: new Percentage(value: 1.0m),
                    affectedBattleParticipants: new List<BattleParticipant> { BattleParticipant.User }),
                new LowerStatModificationMoveEffect(
                    loweredStat: PokemonStat.Defense,
                    loweredStatStages: new Stage(numberOfStages: 1),
                    chanceToLowerStat: new Percentage(value: 1.0m),
                    affectedBattleParticipants: new List<BattleParticipant> { BattleParticipant.User }),
                new LowerStatModificationMoveEffect(
                    loweredStat: PokemonStat.SpecialDefense,
                    loweredStatStages: new Stage(numberOfStages: 1),
                    chanceToLowerStat: new Percentage(value: 1.0m),
                    affectedBattleParticipants: new List<BattleParticipant> { BattleParticipant.User }),
            };
        }
    }
}