using System.Collections.Generic;
using System.Linq;

namespace PokemonStatCalculator.Entities.Types
{
    public class NoneType : Type
    {
        public override PokemonType GetPokemonType()
        {
            return PokemonType.None;
        }

        public override IEnumerable<PokemonType> GetTypeImmunities()
        {
            return Enumerable.Empty<PokemonType>();
        }

        public override IEnumerable<PokemonType> GetTypeResistances()
        {
            return Enumerable.Empty<PokemonType>();
        }

        public override IEnumerable<PokemonType> GetTypeStrengths()
        {
            return Enumerable.Empty<PokemonType>();
        }

        public override IEnumerable<PokemonType> GetTypeWeaknesses()
        {
            return Enumerable.Empty<PokemonType>();
        }
    }
}