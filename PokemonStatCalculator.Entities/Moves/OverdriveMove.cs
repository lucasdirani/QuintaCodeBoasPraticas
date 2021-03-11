using System.Collections.Generic;
using System.Linq;
using PokemonStatCalculator.Entities.Moves.MoveEffects;
using PokemonStatCalculator.Entities.Others;
using PokemonStatCalculator.Entities.Types;

namespace PokemonStatCalculator.Entities.Moves
{
    public sealed class OverdriveMove : Move
    {
        public override PokemonMove MoveName { get; protected set; } = PokemonMove.Overdrive;

        public override PokemonType MoveType { get; protected set; } = PokemonType.Electric;

        public override MoveCategory MoveCategory { get; protected set; } = MoveCategory.Special;

        public override int MovePower { get; protected set; } = 80;

        public override int MovePP { get; protected set; } = 10;

        public override int MovePriority { get; protected set; } = 0;

        public override Percentage MoveAccuracy { get; protected set; } = new Percentage(value: 1.0m);

        public override IEnumerable<MoveEffect> MoveEffects { get; protected set; } = Enumerable.Empty<MoveEffect>();

        public override MoveUsageType MoveUsageType { get; protected set; } = MoveUsageType.None;
    }
}