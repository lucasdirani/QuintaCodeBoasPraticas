using System.Collections.Generic;
using PokemonStatCalculator.Entities.Battles;
using PokemonStatCalculator.Entities.Moves.MoveEffects;
using PokemonStatCalculator.Entities.Moves.MoveEffects.Priority;
using PokemonStatCalculator.Entities.Others;
using PokemonStatCalculator.Entities.Types;

namespace PokemonStatCalculator.Entities.Moves
{
    public sealed class AccelerockMove : Move
    {
        public override PokemonMove MoveName { get; protected set; } = PokemonMove.Accelerock;

        public override PokemonType MoveType { get; protected set; } = PokemonType.Rock;

        public override MoveCategory MoveCategory { get; protected set; } = MoveCategory.Physical;

        public override int MovePower { get; protected set; } = 40;

        public override int MovePP { get; protected set; } = 20;

        public override int MovePriority { get; protected set; } = 1;

        public override Percentage MoveAccuracy { get; protected set; } = new Percentage(value: 1.0m);

        public override IEnumerable<MoveEffect> MoveEffects { get; protected set; } = GetAccelerockMoveEffects();

        public override MoveUsageType MoveUsageType { get; protected set; } = MoveUsageType.None;

        private static IEnumerable<MoveEffect> GetAccelerockMoveEffects()
        {
            return new List<MoveEffect>
            {
                new IncreasedPriorityMoveEffect(
                    priorityNumber: 1,
                    affectedBattleParticipants: new List<BattleParticipant> { BattleParticipant.User }),
            };
        }
    }
}