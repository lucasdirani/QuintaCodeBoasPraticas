using System.Collections.Generic;
using PokemonStatCalculator.Entities.Battles;
using PokemonStatCalculator.Entities.Moves.MoveEffects;
using PokemonStatCalculator.Entities.Moves.MoveEffects.Stats;
using PokemonStatCalculator.Entities.Others;
using PokemonStatCalculator.Entities.Stats;
using PokemonStatCalculator.Entities.Types;

namespace PokemonStatCalculator.Entities.Moves
{
    public sealed class PlayRoughMove : Move
    {
        public override PokemonMove MoveName { get; protected set; } = PokemonMove.PlayRough;

        public override PokemonType MoveType { get; protected set; } = PokemonType.Fairy;

        public override MoveCategory MoveCategory { get; protected set; } = MoveCategory.Physical;

        public override int MovePower { get; protected set; } = 90;

        public override int MovePP { get; protected set; } = 10;

        public override int MovePriority { get; protected set; } = 0;

        public override Percentage MoveAccuracy { get; protected set; } = new Percentage(value: 1.0m);

        public override IEnumerable<MoveEffect> MoveEffects { get; protected set; } = GetPlayRoughMoveEffects();

        public override MoveUsageType MoveUsageType { get; protected set; } = MoveUsageType.None;

        private static IEnumerable<MoveEffect> GetPlayRoughMoveEffects()
        {
            return new List<MoveEffect>
            {
                new LowerStatModificationMoveEffect(
                    loweredStat: PokemonStat.Attack,
                    loweredStatStages: new Stage(numberOfStages: 1),
                    chanceToLowerStat: new Percentage(value: 0.1m),
                    affectedBattleParticipants: new List<BattleParticipant> { BattleParticipant.Target }),
            };
        }
    }
}