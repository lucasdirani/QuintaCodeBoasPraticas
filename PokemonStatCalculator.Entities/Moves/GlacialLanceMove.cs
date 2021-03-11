using System.Collections.Generic;
using System.Linq;
using PokemonStatCalculator.Entities.Moves.MoveEffects;
using PokemonStatCalculator.Entities.Others;
using PokemonStatCalculator.Entities.Types;

namespace PokemonStatCalculator.Entities.Moves
{
    public sealed class GlacialLanceMove : Move
    {
        public override PokemonMove MoveName { get; protected set; } = PokemonMove.GlacialLance;

        public override PokemonType MoveType { get; protected set; } = PokemonType.Ice;

        public override MoveCategory MoveCategory { get; protected set; } = MoveCategory.Physical;

        public override int MovePower { get; protected set; } = 130;

        public override int MovePP { get; protected set; } = 5;

        public override int MovePriority { get; protected set; } = 0;

        public override Percentage MoveAccuracy { get; protected set; } = new Percentage(value: 1.0m);

        public override IEnumerable<MoveEffect> MoveEffects { get; protected set; } = Enumerable.Empty<MoveEffect>();

        public override MoveUsageType MoveUsageType { get; protected set; } = MoveUsageType.None;
    }
}