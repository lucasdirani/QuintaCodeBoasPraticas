using System.Collections.Generic;
using System.Linq;

namespace PokemonStatCalculator.Entities.Types
{
    internal sealed class FlyingType : Type
    {
        public override PokemonType GetPokemonType()
        {
            return PokemonType.Flying;
        }

        public override IEnumerable<PokemonType> GetTypeImmunities()
        {
            return Enumerable.AsEnumerable(new List<PokemonType>
            {
                PokemonType.Ground,
            });
        }

        public override IEnumerable<PokemonType> GetTypeResistances()
        {
            return Enumerable.AsEnumerable(new List<PokemonType>
            {
                PokemonType.Grass,
                PokemonType.Bug,
                PokemonType.Fighting,
            });
        }

        public override IEnumerable<PokemonType> GetTypeStrengths()
        {
            return Enumerable.AsEnumerable(new List<PokemonType>
            {
                PokemonType.Fighting,
                PokemonType.Grass,
                PokemonType.Bug,
            });
        }

        public override IEnumerable<PokemonType> GetTypeWeaknesses()
        {
            return Enumerable.AsEnumerable(new List<PokemonType>
            {
                PokemonType.Electric,
                PokemonType.Rock,
                PokemonType.Ice,
            });
        }
    }
}