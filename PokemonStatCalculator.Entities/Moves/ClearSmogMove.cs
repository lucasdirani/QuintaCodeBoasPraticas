using System.Collections.Generic;
using PokemonStatCalculator.Entities.Battles;
using PokemonStatCalculator.Entities.Moves.MoveEffects;
using PokemonStatCalculator.Entities.Moves.MoveEffects.Stats;
using PokemonStatCalculator.Entities.Others;
using PokemonStatCalculator.Entities.Stats;
using PokemonStatCalculator.Entities.Types;

namespace PokemonStatCalculator.Entities.Moves
{
    public sealed class ClearSmogMove : Move
    {
        public override PokemonMove MoveName { get; protected set; } = PokemonMove.ClearSmog;

        public override PokemonType MoveType { get; protected set; } = PokemonType.Poison;

        public override MoveCategory MoveCategory { get; protected set; } = MoveCategory.Special;

        public override int MovePower { get; protected set; } = 50;

        public override int MovePP { get; protected set; } = 15;

        public override int MovePriority { get; protected set; } = 0;

        public override Percentage MoveAccuracy { get; protected set; } = new Percentage(value: 1.0m);

        public override IEnumerable<MoveEffect> MoveEffects { get; protected set; } = GetClearSmogMoveEffects();

        public override MoveUsageType MoveUsageType { get; protected set; } = MoveUsageType.None;

        private static IEnumerable<MoveEffect> GetClearSmogMoveEffects()
        {
            return new List<MoveEffect>
            {
                new ResetStatModificationMoveEffect(
                    resetedStat: PokemonStat.Attack,
                    resetStatStages: new Stage(numberOfStages: 8),
                    chanceToResetStat: new Percentage(value: 1.0m),
                    affectedBattleParticipants: new List<BattleParticipant> { BattleParticipant.Target }),
                new ResetStatModificationMoveEffect(
                    resetedStat: PokemonStat.Defense,
                    resetStatStages: new Stage(numberOfStages: 8),
                    chanceToResetStat: new Percentage(value: 1.0m),
                    affectedBattleParticipants: new List<BattleParticipant> { BattleParticipant.Target }),
                new ResetStatModificationMoveEffect(
                    resetedStat: PokemonStat.SpecialAttack,
                    resetStatStages: new Stage(numberOfStages: 8),
                    chanceToResetStat: new Percentage(value: 1.0m),
                    affectedBattleParticipants: new List<BattleParticipant> { BattleParticipant.Target }),
                new ResetStatModificationMoveEffect(
                    resetedStat: PokemonStat.SpecialDefense,
                    resetStatStages: new Stage(numberOfStages: 8),
                    chanceToResetStat: new Percentage(value: 1.0m),
                    affectedBattleParticipants: new List<BattleParticipant> { BattleParticipant.Target }),
                new ResetStatModificationMoveEffect(
                    resetedStat: PokemonStat.Speed,
                    resetStatStages: new Stage(numberOfStages: 8),
                    chanceToResetStat: new Percentage(value: 1.0m),
                    affectedBattleParticipants: new List<BattleParticipant> { BattleParticipant.Target }),
            };
        }
    }
}