using System.Collections.Generic;
using PokemonStatCalculator.Entities.Battles;
using PokemonStatCalculator.Entities.Moves.MoveEffects;
using PokemonStatCalculator.Entities.Moves.MoveEffects.HP;
using PokemonStatCalculator.Entities.Others;
using PokemonStatCalculator.Entities.Types;

namespace PokemonStatCalculator.Entities.Moves
{
    public sealed class AquaRingMove : Move
    {
        public override PokemonMove MoveName { get; protected set; } = PokemonMove.AquaRing;

        public override PokemonType MoveType { get; protected set; } = PokemonType.Water;

        public override MoveCategory MoveCategory { get; protected set; } = MoveCategory.NonDamaging;

        public override int MovePower { get; protected set; } = 0;

        public override int MovePP { get; protected set; } = 20;

        public override int MovePriority { get; protected set; } = 0;

        public override Percentage MoveAccuracy { get; protected set; } = new Percentage(value: 1.0m);

        public override IEnumerable<MoveEffect> MoveEffects { get; protected set; } = GetAquaRingMoveEffects();

        public override MoveUsageType MoveUsageType { get; protected set; } = MoveUsageType.None;

        private static IEnumerable<MoveEffect> GetAquaRingMoveEffects()
        {
            return new List<MoveEffect>
            {
                new RestoreHPMoveEffect(
                    restoredHP: new Percentage(value: 0.0625m),
                    hpRestoredOnTheSameTurn: true,
                    hpRecoveredInMoreThanOneTurn: true,
                    affectedBattleParticipants: new List<BattleParticipant> { BattleParticipant.User }),
            };
        }
    }
}