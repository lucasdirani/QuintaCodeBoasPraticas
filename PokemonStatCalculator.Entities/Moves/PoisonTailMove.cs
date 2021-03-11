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
    public sealed class PoisonTailMove : Move
    {
        public override PokemonMove MoveName { get; protected set; } = PokemonMove.PoisonTail;

        public override PokemonType MoveType { get; protected set; } = PokemonType.Poison;

        public override MoveCategory MoveCategory { get; protected set; } = MoveCategory.Physical;

        public override int MovePower { get; protected set; } = 50;

        public override int MovePP { get; protected set; } = 25;

        public override int MovePriority { get; protected set; } = 0;

        public override Percentage MoveAccuracy { get; protected set; } = new Percentage(value: 1.0m);

        public override IEnumerable<MoveEffect> MoveEffects { get; protected set; } = GetPoisonTailMoveEffects();

        public override MoveUsageType MoveUsageType { get; protected set; } = MoveUsageType.None;

        private static IEnumerable<MoveEffect> GetPoisonTailMoveEffects()
        {
            return new List<MoveEffect>
            {
                new HighCriticalHitMoveEffect(
                    chanceToCriticalHit: new Percentage(value: 0.5m),
                    affectedBattleParticipants: new List<BattleParticipant> { BattleParticipant.User }),
                new InflictStatusConditionMoveEffect(
                    inflictedStatusCondition: StatusConditionType.Poison,
                    chanceToInflictStatusCondition: new Percentage(value: 0.1m),
                    affectedBattleParticipants: new List<BattleParticipant> { BattleParticipant.Target }),
            };
        }
    }
}