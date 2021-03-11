using System.Collections.Generic;
using PokemonStatCalculator.Entities.Battles;
using PokemonStatCalculator.Entities.Moves;

namespace PokemonStatCalculator.Entities.Abilities.AbilityEffects.Priority
{
    public sealed class MoveCategoryPriorityAbilityEffect : PriorityAbilityEffect
    {
        public MoveCategoryPriorityAbilityEffect(
            IEnumerable<MoveCategory> moveCategoriesWithPriority,
            int priorityBoostedLevel,
            IEnumerable<BattleParticipant> affectedBattleParticipants)
            : base(priorityBoostedLevel, affectedBattleParticipants)
        {
            MoveCategoriesWithPriority = moveCategoriesWithPriority;
        }

        public override AbilityEffectType AbilityEffectType { get; protected set; } = AbilityEffectType.MoveCategoryPriority;

        public IEnumerable<MoveCategory> MoveCategoriesWithPriority { get; private set; }
    }
}