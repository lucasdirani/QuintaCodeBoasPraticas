using System.Collections.Generic;
using PokemonStatCalculator.Entities.Battles;
using PokemonStatCalculator.Entities.Moves.MoveEffects;
using PokemonStatCalculator.Entities.Moves.MoveEffects.Critical;
using PokemonStatCalculator.Entities.Others;
using PokemonStatCalculator.Entities.Types;

namespace PokemonStatCalculator.Entities.Moves
{
    public sealed class NightSlashMove : Move
    {
        public override PokemonMove MoveName { get; protected set; } = PokemonMove.NightSlash;

        public override PokemonType MoveType { get; protected set; } = PokemonType.Dark;

        public override MoveCategory MoveCategory { get; protected set; } = MoveCategory.Physical;

        public override int MovePower { get; protected set; } = 70;

        public override int MovePP { get; protected set; } = 15;

        public override int MovePriority { get; protected set; } = 0;

        public override Percentage MoveAccuracy { get; protected set; } = new Percentage(value: 1.0m);

        public override IEnumerable<MoveEffect> MoveEffects { get; protected set; } = GetNightSlashMoveEffects();

        public override MoveUsageType MoveUsageType { get; protected set; } = MoveUsageType.None;

        private static IEnumerable<MoveEffect> GetNightSlashMoveEffects()
        {
            return new List<MoveEffect>
            {
                new HighCriticalHitMoveEffect(
                    chanceToCriticalHit: new Percentage(value: 0.5m),
                    affectedBattleParticipants: new List<BattleParticipant> { BattleParticipant.User }),
            };
        }
    }
}