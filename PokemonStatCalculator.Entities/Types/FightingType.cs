using System.Collections.Generic;
using System.Linq;

namespace PokemonStatCalculator.Entities.Types
{
    internal sealed class FightingType : Type
    {
        public override PokemonType GetPokemonType()
        {
            return PokemonType.Fighting;
        }

        public override IEnumerable<PokemonType> GetTypeImmunities()
        {
            return Enumerable.Empty<PokemonType>();
        }

        public override IEnumerable<PokemonType> GetTypeResistances()
        {
            return Enumerable.AsEnumerable(new List<PokemonType>
            {
                PokemonType.Bug,
                PokemonType.Rock,
                PokemonType.Dark,
            });
        }

        public override IEnumerable<PokemonType> GetTypeStrengths()
        {
            return Enumerable.AsEnumerable(new List<PokemonType>
            {
                PokemonType.Normal,
                PokemonType.Rock,
                PokemonType.Steel,
                PokemonType.Dark,
                PokemonType.Ice,
            });
        }

        public override IEnumerable<PokemonType> GetTypeWeaknesses()
        {
            return Enumerable.AsEnumerable(new List<PokemonType>
            {
                PokemonType.Flying,
                PokemonType.Psychic,
                PokemonType.Fairy,
            });
        }
    }
}