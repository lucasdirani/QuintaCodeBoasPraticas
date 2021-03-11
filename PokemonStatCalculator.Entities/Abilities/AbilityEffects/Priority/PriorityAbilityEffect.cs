using System.Collections.Generic;
using PokemonStatCalculator.Entities.Battles;

namespace PokemonStatCalculator.Entities.Abilities.AbilityEffects.Priority
{
    public abstract class PriorityAbilityEffect : AbilityEffect
    {
        protected PriorityAbilityEffect(
            int priorityBoostedLevel,
            IEnumerable<BattleParticipant> affectedBattleParticipants)
            : base(affectedBattleParticipants)
        {
            PriorityBoostedLevel = priorityBoostedLevel;
        }

        public int PriorityBoostedLevel { get; protected set; }
    }
}