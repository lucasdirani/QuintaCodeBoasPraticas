using System.Collections.Generic;
using System.Linq;

namespace PokemonStatCalculator.Entities.Types
{
    internal sealed class IceType : Type
    {
        public override PokemonType GetPokemonType()
        {
            return PokemonType.Ice;
        }

        public override IEnumerable<PokemonType> GetTypeImmunities()
        {
            return Enumerable.Empty<PokemonType>();
        }

        public override IEnumerable<PokemonType> GetTypeResistances()
        {
            return Enumerable.AsEnumerable(new List<PokemonType>
            {
                PokemonType.Ice,
            });
        }

        public override IEnumerable<PokemonType> GetTypeStrengths()
        {
            return Enumerable.AsEnumerable(new List<PokemonType>
            {
                PokemonType.Flying,
                PokemonType.Ground,
                PokemonType.Grass,
                PokemonType.Dragon,
            });
        }

        public override IEnumerable<PokemonType> GetTypeWeaknesses()
        {
            return Enumerable.AsEnumerable(new List<PokemonType>
            {
                PokemonType.Fighting,
                PokemonType.Steel,
                PokemonType.Rock,
                PokemonType.Fire,
            });
        }
    }
}