using System.Collections.Generic;
using System.Linq;

namespace PokemonStatCalculator.Entities.Types
{
    internal sealed class FireType : Type
    {
        public override PokemonType GetPokemonType()
        {
            return PokemonType.Fire;
        }

        public override IEnumerable<PokemonType> GetTypeImmunities()
        {
            return Enumerable.Empty<PokemonType>();
        }

        public override IEnumerable<PokemonType> GetTypeResistances()
        {
            return Enumerable.AsEnumerable(new List<PokemonType>
            {
                PokemonType.Fire,
                PokemonType.Grass,
                PokemonType.Ice,
                PokemonType.Bug,
                PokemonType.Steel,
                PokemonType.Fairy,
            });
        }

        public override IEnumerable<PokemonType> GetTypeStrengths()
        {
            return Enumerable.AsEnumerable(new List<PokemonType>
            {
                PokemonType.Grass,
                PokemonType.Ice,
                PokemonType.Bug,
                PokemonType.Steel,
            });
        }

        public override IEnumerable<PokemonType> GetTypeWeaknesses()
        {
            return Enumerable.AsEnumerable(new List<PokemonType>
            {
                PokemonType.Water,
                PokemonType.Rock,
                PokemonType.Ground,
            });
        }
    }
}