using System.Collections.Generic;
using System.Linq;
using PokemonStatCalculator.Entities.Abilities.AbilityEffects;

namespace PokemonStatCalculator.Entities.Abilities
{
    public abstract class Ability
    {
        public static Ability CreateFromPokemonAbility(PokemonAbility pokemonAbility) => AbilityContainer.GetAbilityByPokemonAbility(pokemonAbility);

        public abstract PokemonAbility GetPokemonAbility();

        public abstract IEnumerable<AbilityEffect> GetAbilityEffects();

        public abstract bool CheckIfAbilityActivatesOnTheBeginningfTheBattle();

        public abstract bool CheckIfAbilityActivatesOnExitingfTheBattle();

        public abstract bool CheckIfAbilityActivatesOnTheEndOfTheTurn();

        public abstract bool CheckIfAbilityCanBeCopied();

        public bool CheckIfAbilityIsImmunyTo(Ability ability)
        {
            return GetImmunyAbilities().Contains(ability.GetPokemonAbility());
        }

        protected abstract IEnumerable<PokemonAbility> GetImmunyAbilities();

        private static class AbilityContainer
        {
            private static readonly IDictionary<PokemonAbility, Ability> Abilities = InitializeAbilityContainer();

            public static Ability GetAbilityByPokemonAbility(PokemonAbility pokemonAbility) => Abilities[pokemonAbility];

            private static Dictionary<PokemonAbility, Ability> InitializeAbilityContainer() => new Dictionary<PokemonAbility, Ability>()
            {
                { PokemonAbility.Aftermath, new AftermathAbility() },
                { PokemonAbility.AngerPoint, new AngerPointAbility() },
                { PokemonAbility.BeastBoost, new BeastBoostAbility() },
                { PokemonAbility.Berserk, new BerserkAbility() },
                { PokemonAbility.ChillingNeigh, new ChillingNeighAbility() },
                { PokemonAbility.Chlorophyll, new ChlorophyllAbility() },
                { PokemonAbility.Competitive, new CompetitiveAbility() },
                { PokemonAbility.CuteCharm, new CuteCharmAbility() },
                { PokemonAbility.DauntlessShield, new DauntlessShieldAbility() },
                { PokemonAbility.EffectSpore, new EffectSporeAbility() },
                { PokemonAbility.GaleWings, new GaleWingsAbility() },
                { PokemonAbility.GrassPelt, new GrassPeltAbility() },
                { PokemonAbility.Justified, new JustifiedAbility() },
            };
        }
    }
}