using System.Collections.Generic;
using PokemonStatCalculator.Entities.Battles;
using PokemonStatCalculator.Entities.Moves.MoveEffects;
using PokemonStatCalculator.Entities.Moves.MoveEffects.StatusCondition;
using PokemonStatCalculator.Entities.Others;
using PokemonStatCalculator.Entities.StatusConditions;
using PokemonStatCalculator.Entities.Types;

namespace PokemonStatCalculator.Entities.Moves
{
    public sealed class NuzzleMove : Move
    {
        public override PokemonMove MoveName { get; protected set; } = PokemonMove.Nuzzle;

        public override PokemonType MoveType { get; protected set; } = PokemonType.Electric;

        public override MoveCategory MoveCategory { get; protected set; } = MoveCategory.Physical;

        public override int MovePower { get; protected set; } = 20;

        public override int MovePP { get; protected set; } = 20;

        public override int MovePriority { get; protected set; } = 0;

        public override Percentage MoveAccuracy { get; protected set; } = new Percentage(value: 1.0m);

        public override IEnumerable<MoveEffect> MoveEffects { get; protected set; } = GetNuzzleMoveEffects();

        public override MoveUsageType MoveUsageType { get; protected set; } = MoveUsageType.None;

        private static IEnumerable<MoveEffect> GetNuzzleMoveEffects()
        {
            return new List<MoveEffect>
            {
                new InflictStatusConditionMoveEffect(
                    inflictedStatusCondition: StatusConditionType.Paralyzed,
                    chanceToInflictStatusCondition: new Percentage(value: 1.0m),
                    affectedBattleParticipants: new List<BattleParticipant> { BattleParticipant.Target }),
            };
        }
    }
}