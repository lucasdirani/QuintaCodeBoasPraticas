using System.Collections.Generic;
using PokemonStatCalculator.Entities.Battles;

namespace PokemonStatCalculator.Entities.Abilities.AbilityEffects.Contact
{
    public sealed class ChangeAbilityOnContactAbilityEffect : ContactAbilityEffect
    {
        public ChangeAbilityOnContactAbilityEffect(
            PokemonAbility newPokemonAbility,
            IEnumerable<BattleParticipant> affectedBattleParticipants)
            : base(affectedBattleParticipants)
        {
            NewPokemonAbility = newPokemonAbility;
        }

        public override AbilityEffectType AbilityEffectType { get; protected set; } = AbilityEffectType.ChangeAbilityOnContact;

        public PokemonAbility NewPokemonAbility { get; private set; }
    }
}