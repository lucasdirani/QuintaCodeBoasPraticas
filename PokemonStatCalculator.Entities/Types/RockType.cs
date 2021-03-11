using System.Collections.Generic;
using System.Linq;

namespace PokemonStatCalculator.Entities.Types
{
    internal class RockType : Type
    {
        public override PokemonType GetPokemonType()
        {
            return PokemonType.Rock;
        }

        public override IEnumerable<PokemonType> GetTypeImmunities()
        {
            return Enumerable.Empty<PokemonType>();
        }

        public override IEnumerable<PokemonType> GetTypeResistances()
        {
            return Enumerable.AsEnumerable(new List<PokemonType>
            {
                PokemonType.Normal,
                PokemonType.Fire,
                PokemonType.Poison,
                PokemonType.Flying,
            });
        }

        public override IEnumerable<PokemonType> GetTypeStrengths()
        {
            return Enumerable.AsEnumerable(new List<PokemonType>
            {
                PokemonType.Flying,
                PokemonType.Bug,
                PokemonType.Fire,
                PokemonType.Ice,
            });
        }

        public override IEnumerable<PokemonType> GetTypeWeaknesses()
        {
            return Enumerable.AsEnumerable(new List<PokemonType>
            {
                PokemonType.Water,
                PokemonType.Grass,
                PokemonType.Steel,
                PokemonType.Fighting,
                PokemonType.Ground,
            });
        }
    }
}