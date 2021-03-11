using System.Collections.Generic;
using System.Linq;

namespace PokemonStatCalculator.Entities.Types
{
    internal sealed class WaterType : Type
    {
        public override PokemonType GetPokemonType()
        {
            return PokemonType.Water;
        }

        public override IEnumerable<PokemonType> GetTypeImmunities()
        {
            return Enumerable.Empty<PokemonType>();
        }

        public override IEnumerable<PokemonType> GetTypeResistances()
        {
            return Enumerable.AsEnumerable(new List<PokemonType>
            {
                PokemonType.Water,
                PokemonType.Ice,
                PokemonType.Fire,
                PokemonType.Steel,
            });
        }

        public override IEnumerable<PokemonType> GetTypeStrengths()
        {
            return Enumerable.AsEnumerable(new List<PokemonType>
            {
                PokemonType.Fire,
                PokemonType.Rock,
                PokemonType.Ground,
            });
        }

        public override IEnumerable<PokemonType> GetTypeWeaknesses()
        {
            return Enumerable.AsEnumerable(new List<PokemonType>
            {
                PokemonType.Electric,
                PokemonType.Grass,
            });
        }
    }
}