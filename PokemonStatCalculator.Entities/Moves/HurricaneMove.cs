using System.Collections.Generic;
using PokemonStatCalculator.Entities.Battles;
using PokemonStatCalculator.Entities.Moves.MoveEffects;
using PokemonStatCalculator.Entities.Moves.MoveEffects.Accuracy;
using PokemonStatCalculator.Entities.Moves.MoveEffects.StatusCondition;
using PokemonStatCalculator.Entities.Others;
using PokemonStatCalculator.Entities.StatusConditions;
using PokemonStatCalculator.Entities.Types;

namespace PokemonStatCalculator.Entities.Moves
{
    public sealed class HurricaneMove : Move
    {
        public override PokemonMove MoveName { get; protected set; } = PokemonMove.Hurricane;

        public override PokemonType MoveType { get; protected set; } = PokemonType.Flying;

        public override MoveCategory MoveCategory { get; protected set; } = MoveCategory.Special;

        public override int MovePower { get; protected set; } = 110;

        public override int MovePP { get; protected set; } = 10;

        public override int MovePriority { get; protected set; } = 0;

        public override Percentage MoveAccuracy { get; protected set; } = new Percentage(value: 0.7m);

        public override IEnumerable<MoveEffect> MoveEffects { get; protected set; } = GetHurricaneMoveEffects();

        public override MoveUsageType MoveUsageType { get; protected set; } = MoveUsageType.None;

        private static IEnumerable<MoveEffect> GetHurricaneMoveEffects()
        {
            return new List<MoveEffect>
            {
                new InflictStatusConditionMoveEffect(
                    inflictedStatusCondition: StatusConditionType.Confusion,
                    chanceToInflictStatusCondition: new Percentage(0.3m),
                    affectedBattleParticipants: new List<BattleParticipant> { BattleParticipant.Target }),
                new IgnoreAccuracyMoveEffect(
                    chanceToIgnoreAccuracy: new Percentage(value: 1.0m),
                    affectedBattleParticipants: new List<BattleParticipant> { BattleParticipant.User }),
            };
        }
    }
}