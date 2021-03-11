using System.Collections.Generic;
using PokemonStatCalculator.Entities.Battles;
using PokemonStatCalculator.Entities.Moves.MoveEffects;
using PokemonStatCalculator.Entities.Moves.MoveEffects.Flinch;
using PokemonStatCalculator.Entities.Moves.MoveEffects.StatusCondition;
using PokemonStatCalculator.Entities.Others;
using PokemonStatCalculator.Entities.StatusConditions;
using PokemonStatCalculator.Entities.Types;

namespace PokemonStatCalculator.Entities.Moves
{
    public sealed class FireFangMove : Move
    {
        public override PokemonMove MoveName { get; protected set; } = PokemonMove.FireFang;

        public override PokemonType MoveType { get; protected set; } = PokemonType.Fire;

        public override MoveCategory MoveCategory { get; protected set; } = MoveCategory.Physical;

        public override int MovePower { get; protected set; } = 65;

        public override int MovePP { get; protected set; } = 15;

        public override int MovePriority { get; protected set; } = 0;

        public override Percentage MoveAccuracy { get; protected set; } = new Percentage(value: 0.95m);

        public override IEnumerable<MoveEffect> MoveEffects { get; protected set; } = GetFireFangMoveEffects();

        public override MoveUsageType MoveUsageType { get; protected set; } = MoveUsageType.Biting;

        private static IEnumerable<MoveEffect> GetFireFangMoveEffects()
        {
            return new List<MoveEffect>
            {
                new InflictStatusConditionMoveEffect(
                    inflictedStatusCondition: StatusConditionType.Burn,
                    chanceToInflictStatusCondition: new Percentage(value: 0.1m),
                    affectedBattleParticipants: new List<BattleParticipant> { BattleParticipant.Target }),
                new FlinchingMoveEffect(
                    chanceOfCauseFlinching: new Percentage(value: 0.1m),
                    affectedBattleParticipants: new List<BattleParticipant> { BattleParticipant.Target }),
            };
        }
    }
}