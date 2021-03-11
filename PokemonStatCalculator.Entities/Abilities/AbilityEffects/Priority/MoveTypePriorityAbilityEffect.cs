using System.Collections.Generic;
using PokemonStatCalculator.Entities.Battles;
using PokemonStatCalculator.Entities.Types;

namespace PokemonStatCalculator.Entities.Abilities.AbilityEffects.Priority
{
    public sealed class MoveTypePriorityAbilityEffect : PriorityAbilityEffect
    {
        public MoveTypePriorityAbilityEffect(
            IEnumerable<PokemonType> moveTypesWithPriority,
            int priorityBoostedLevel,
            IEnumerable<BattleParticipant> affectedBattleParticipants)
            : base(priorityBoostedLevel, affectedBattleParticipants)
        {
            MoveTypesWithPriority = moveTypesWithPriority;
        }

        public override AbilityEffectType AbilityEffectType { get; protected set; } = AbilityEffectType.MoveTypePriority;

        public IEnumerable<PokemonType> MoveTypesWithPriority { get; private set; }
    }
}