using System.Collections.Generic;
using PokemonStatCalculator.Entities.Battles;
using PokemonStatCalculator.Entities.Moves.MoveEffects;
using PokemonStatCalculator.Entities.Moves.MoveEffects.Stats;
using PokemonStatCalculator.Entities.Others;
using PokemonStatCalculator.Entities.Stats;
using PokemonStatCalculator.Entities.Types;

namespace PokemonStatCalculator.Entities.Moves
{
    public sealed class LeafStormMove : Move
    {
        public override PokemonMove MoveName { get; protected set; } = PokemonMove.LeafStorm;

        public override PokemonType MoveType { get; protected set; } = PokemonType.Grass;

        public override MoveCategory MoveCategory { get; protected set; } = MoveCategory.Special;

        public override int MovePower { get; protected set; } = 130;

        public override int MovePP { get; protected set; } = 5;

        public override int MovePriority { get; protected set; } = 0;

        public override Percentage MoveAccuracy { get; protected set; } = new Percentage(value: 0.9m);

        public override IEnumerable<MoveEffect> MoveEffects { get; protected set; } = GetLeafStormMoveEffects();

        public override MoveUsageType MoveUsageType { get; protected set; } = MoveUsageType.None;

        private static IEnumerable<MoveEffect> GetLeafStormMoveEffects()
        {
            return new List<MoveEffect>
            {
                new LowerStatModificationMoveEffect(
                    loweredStat: PokemonStat.SpecialAttack,
                    loweredStatStages: new Stage(numberOfStages: 2),
                    chanceToLowerStat: new Percentage(value: 1.0m),
                    affectedBattleParticipants: new List<BattleParticipant> { BattleParticipant.User }),
            };
        }
    }
}