using System.Collections.Generic;
using PokemonStatCalculator.Entities.Battles;

namespace PokemonStatCalculator.Entities.Abilities.AbilityEffects
{
    public abstract class AbilityEffect
    {
        protected AbilityEffect(IEnumerable<BattleParticipant> affectedBattleParticipants)
        {
            AffectedBattleParticipants = affectedBattleParticipants;
        }

        public abstract AbilityEffectType AbilityEffectType { get; protected set; }

        public IEnumerable<BattleParticipant> AffectedBattleParticipants { get; protected set; }
    }
}