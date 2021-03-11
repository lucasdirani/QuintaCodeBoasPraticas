using System.Collections.Generic;
using PokemonStatCalculator.Entities.Battles;
using PokemonStatCalculator.Entities.Moves;

namespace PokemonStatCalculator.Entities.Abilities.AbilityEffects.Priority
{
    public sealed class MoveActionPriorityAbilityEffect : PriorityAbilityEffect
    {
        public MoveActionPriorityAbilityEffect(
            IEnumerable<MoveAction> moveActionsWithPriority,
            int priorityBoostedLevel,
            IEnumerable<BattleParticipant> affectedBattleParticipants)
            : base(priorityBoostedLevel, affectedBattleParticipants)
        {
            MoveActionsWithPriority = moveActionsWithPriority;
        }

        public override AbilityEffectType AbilityEffectType { get; protected set; } = AbilityEffectType.MoveActionPriority;

        public IEnumerable<MoveAction> MoveActionsWithPriority { get; private set; }
    }
}