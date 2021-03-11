using System.Collections.Generic;
using PokemonStatCalculator.Entities.Battles;
using PokemonStatCalculator.Entities.Moves.MoveEffects;
using PokemonStatCalculator.Entities.Moves.MoveEffects.Recoil;
using PokemonStatCalculator.Entities.Others;
using PokemonStatCalculator.Entities.Types;

namespace PokemonStatCalculator.Entities.Moves
{
    public sealed class MindBlownMove : Move
    {
        public override PokemonMove MoveName { get; protected set; } = PokemonMove.MindBlown;

        public override PokemonType MoveType { get; protected set; } = PokemonType.Fire;

        public override MoveCategory MoveCategory { get; protected set; } = MoveCategory.Special;

        public override int MovePower { get; protected set; } = 150;

        public override int MovePP { get; protected set; } = 5;

        public override int MovePriority { get; protected set; } = 0;

        public override Percentage MoveAccuracy { get; protected set; } = new Percentage(value: 1.0m);

        public override IEnumerable<MoveEffect> MoveEffects { get; protected set; } = GetMindBlownMoveEffects();

        public override MoveUsageType MoveUsageType { get; protected set; } = MoveUsageType.None;

        private static IEnumerable<MoveEffect> GetMindBlownMoveEffects()
        {
            return new List<MoveEffect>
            {
                new RecoilMoveEffect(
                    recoilDamage: new Percentage(value: 0.5m),
                    affectedBattleParticipants: new List<BattleParticipant> { BattleParticipant.User }),
            };
        }
    }
}