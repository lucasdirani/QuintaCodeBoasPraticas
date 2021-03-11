using System.Collections.Generic;
using PokemonStatCalculator.Entities.Battles;
using PokemonStatCalculator.Entities.Moves.MoveEffects;
using PokemonStatCalculator.Entities.Moves.MoveEffects.Recoil;
using PokemonStatCalculator.Entities.Moves.MoveEffects.Stats;
using PokemonStatCalculator.Entities.Others;
using PokemonStatCalculator.Entities.Stats;
using PokemonStatCalculator.Entities.Types;

namespace PokemonStatCalculator.Entities.Moves
{
    public sealed class BellyDrumMove : Move
    {
        public override PokemonMove MoveName { get; protected set; } = PokemonMove.BellyDrum;

        public override PokemonType MoveType { get; protected set; } = PokemonType.Normal;

        public override MoveCategory MoveCategory { get; protected set; } = MoveCategory.NonDamaging;

        public override int MovePower { get; protected set; } = 0;

        public override int MovePP { get; protected set; } = 10;

        public override int MovePriority { get; protected set; } = 0;

        public override Percentage MoveAccuracy { get; protected set; } = new Percentage(value: 1.0m);

        public override IEnumerable<MoveEffect> MoveEffects { get; protected set; } = GetBellyDrumMoveEffects();

        public override MoveUsageType MoveUsageType { get; protected set; } = MoveUsageType.None;

        private static IEnumerable<MoveEffect> GetBellyDrumMoveEffects()
        {
            return new List<MoveEffect>
            {
                new RecoilMoveEffect(
                    recoilDamage: new Percentage(value: 0.5m),
                    affectedBattleParticipants: new List<BattleParticipant> { BattleParticipant.User }),
                new RaiseStatModificationMoveEffect(
                    raisedStat: PokemonStat.Attack,
                    raisedStatStages: new Stage(numberOfStages: 8),
                    chanceToRaiseStat: new Percentage(value: 1.0m),
                    affectedBattleParticipants: new List<BattleParticipant> { BattleParticipant.User }),
            };
        }
    }
}