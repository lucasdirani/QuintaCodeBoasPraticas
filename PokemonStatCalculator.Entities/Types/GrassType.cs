using System.Collections.Generic;
using System.Linq;

namespace PokemonStatCalculator.Entities.Types
{
    internal sealed class GrassType : Type
    {
        public override PokemonType GetPokemonType()
        {
            return PokemonType.Grass;
        }

        public override IEnumerable<PokemonType> GetTypeImmunities()
        {
            return Enumerable.Empty<PokemonType>();
        }

        public override IEnumerable<PokemonType> GetTypeResistances()
        {
            return Enumerable.AsEnumerable(new List<PokemonType>
            {
                PokemonType.Grass,
                PokemonType.Water,
                PokemonType.Electric,
                PokemonType.Ground,
            });
        }

        public override IEnumerable<PokemonType> GetTypeStrengths()
        {
            return Enumerable.AsEnumerable(new List<PokemonType>
            {
                PokemonType.Water,
                PokemonType.Rock,
                PokemonType.Ground,
            });
        }

        public override IEnumerable<PokemonType> GetTypeWeaknesses()
        {
            return Enumerable.AsEnumerable(new List<PokemonType>
            {
                PokemonType.Fire,
                PokemonType.Flying,
                PokemonType.Bug,
                PokemonType.Ice,
                PokemonType.Poison,
            });
        }
    }
}