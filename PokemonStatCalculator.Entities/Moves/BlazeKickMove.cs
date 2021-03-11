using System.Collections.Generic;
using PokemonStatCalculator.Entities.Battles;
using PokemonStatCalculator.Entities.Moves.MoveEffects;
using PokemonStatCalculator.Entities.Moves.MoveEffects.Critical;
using PokemonStatCalculator.Entities.Moves.MoveEffects.StatusCondition;
using PokemonStatCalculator.Entities.Others;
using PokemonStatCalculator.Entities.StatusConditions;
using PokemonStatCalculator.Entities.Types;

namespace PokemonStatCalculator.Entities.Moves
{
    public sealed class BlazeKickMove : Move
    {
        public override PokemonMove MoveName { get; protected set; } = PokemonMove.BlazeKick;

        public override PokemonType MoveType { get; protected set; } = PokemonType.Fire;

        public override MoveCategory MoveCategory { get; protected set; } = MoveCategory.Physical;

        public override int MovePower { get; protected set; } = 85;

        public override int MovePP { get; protected set; } = 10;

        public override int MovePriority { get; protected set; } = 0;

        public override Percentage MoveAccuracy { get; protected set; } = new Percentage(value: 0.9m);

        public override IEnumerable<MoveEffect> MoveEffects { get; protected set; } = GetBlazeKickMoveEffects();

        public override MoveUsageType MoveUsageType { get; protected set; } = MoveUsageType.None;

        private static IEnumerable<MoveEffect> GetBlazeKickMoveEffects()
        {
            return new List<MoveEffect>
            {
                new HighCriticalHitMoveEffect(
                    chanceToCriticalHit: new Percentage(value: 0.5m),
                    affectedBattleParticipants: new List<BattleParticipant> { BattleParticipant.User }),
                new InflictStatusConditionMoveEffect(
                    inflictedStatusCondition: StatusConditionType.Burn,
                    chanceToInflictStatusCondition: new Percentage(value: 0.1m),
                    affectedBattleParticipants: new List<BattleParticipant> { BattleParticipant.Target }),
            };
        }
    }
}