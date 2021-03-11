using System.Collections.Generic;
using System.Linq;
using PokemonStatCalculator.Utils.ExtensionMethods;
using PokemonStatCalculator.Utils.Monads.Results;

namespace PokemonStatCalculator.Entities.Types
{
    public abstract class Type
    {
        public static Result<Type> CreateFromPokemonType(PokemonType pokemonType)
        {
            Type createdType = TypeContainer.GetTypeFromPokemonType(pokemonType);

            if (createdType.GetPokemonType() == PokemonType.None)
            {
                return Result.Fail<Type>($"The type of {pokemonType.GetDescription()} is not available.");
            }

            return Result.Success(createdType);
        }

        public abstract PokemonType GetPokemonType();

        public abstract IEnumerable<PokemonType> GetTypeImmunities();

        public abstract IEnumerable<PokemonType> GetTypeResistances();

        public abstract IEnumerable<PokemonType> GetTypeWeaknesses();

        public abstract IEnumerable<PokemonType> GetTypeStrengths();

        public bool CheckIfHasImmunityTo(PokemonType pokemonType) => GetTypeImmunities().Contains(pokemonType);

        public bool CheckIfHasResistanceTo(PokemonType pokemonType) => GetTypeResistances().Contains(pokemonType);

        public bool CheckIfHasWeaknessTo(PokemonType pokemonType) => GetTypeWeaknesses().Contains(pokemonType);

        public bool CheckIfHasStrengthTo(PokemonType pokemonType) => GetTypeStrengths().Contains(pokemonType);

        public bool CheckIfReceiveNormalDamageFrom(PokemonType pokemonType) =>
            !CheckIfHasImmunityTo(pokemonType) &&
            !CheckIfHasResistanceTo(pokemonType) &&
            !CheckIfHasWeaknessTo(pokemonType);

        private static class TypeContainer
        {
            private static readonly IDictionary<PokemonType, Type> Types = InitializeTypeContainer();

            public static Type GetTypeFromPokemonType(PokemonType pokemonType)
                => Types.ContainsKey(pokemonType) ? Types[pokemonType] : new NoneType();

            private static Dictionary<PokemonType, Type> InitializeTypeContainer() => new Dictionary<PokemonType, Type>()
            {
                { PokemonType.Bug, new BugType() },
                { PokemonType.Dark, new DarkType() },
                { PokemonType.Dragon, new DragonType() },
                { PokemonType.Electric, new ElectricType() },
                { PokemonType.Fairy, new FairyType() },
                { PokemonType.Fighting, new FightingType() },
                { PokemonType.Fire, new FireType() },
                { PokemonType.Flying, new FlyingType() },
                { PokemonType.Ghost, new GhostType() },
                { PokemonType.Grass, new GrassType() },
                { PokemonType.Ground, new GroundType() },
                { PokemonType.Ice, new IceType() },
                { PokemonType.Normal, new NormalType() },
                { PokemonType.Poison, new PoisonType() },
                { PokemonType.Psychic, new PsychicType() },
                { PokemonType.Rock, new RockType() },
                { PokemonType.Steel, new SteelType() },
                { PokemonType.Water, new WaterType() },
            };
        }
    }
}