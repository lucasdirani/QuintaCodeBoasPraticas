using System.Collections.Generic;
using PokemonStatCalculator.Entities.Battles;
using PokemonStatCalculator.Entities.Moves.MoveEffects;
using PokemonStatCalculator.Entities.Moves.MoveEffects.Flinch;
using PokemonStatCalculator.Entities.Others;
using PokemonStatCalculator.Entities.Types;

namespace PokemonStatCalculator.Entities.Moves
{
    public sealed class AirSlashMove : Move
    {
        public override PokemonMove MoveName { get; protected set; } = PokemonMove.AirSlash;

        public override PokemonType MoveType { get; protected set; } = PokemonType.Flying;

        public override MoveCategory MoveCategory { get; protected set; } = MoveCategory.Special;

        public override int MovePower { get; protected set; } = 75;

        public override int MovePP { get; protected set; } = 15;

        public override int MovePriority { get; protected set; } = 0;

        public override Percentage MoveAccuracy { get; protected set; } = new Percentage(value: 0.95m);

        public override IEnumerable<MoveEffect> MoveEffects { get; protected set; } = GetAirSlashMoveEffects();

        public override MoveUsageType MoveUsageType { get; protected set; } = MoveUsageType.None;

        private static IEnumerable<MoveEffect> GetAirSlashMoveEffects()
        {
            return new List<MoveEffect>
            {
                new FlinchingMoveEffect(
                    chanceOfCauseFlinching: new Percentage(value: 0.3m),
                    affectedBattleParticipants: new List<BattleParticipant> { BattleParticipant.Target }),
            };
        }
    }
}