using System.Collections.Generic;
using System.Linq;

namespace PokemonStatCalculator.Entities.Types
{
    internal sealed class GhostType : Type
    {
        public override PokemonType GetPokemonType()
        {
            return PokemonType.Ghost;
        }

        public override IEnumerable<PokemonType> GetTypeImmunities()
        {
            return Enumerable.AsEnumerable(new List<PokemonType>
            {
                PokemonType.Fighting,
                PokemonType.Normal,
            });
        }

        public override IEnumerable<PokemonType> GetTypeResistances()
        {
            return Enumerable.AsEnumerable(new List<PokemonType>
            {
                PokemonType.Poison,
                PokemonType.Bug,
            });
        }

        public override IEnumerable<PokemonType> GetTypeStrengths()
        {
            return Enumerable.AsEnumerable(new List<PokemonType>
            {
                PokemonType.Ghost,
                PokemonType.Psychic,
            });
        }

        public override IEnumerable<PokemonType> GetTypeWeaknesses()
        {
            return Enumerable.AsEnumerable(new List<PokemonType>
            {
                PokemonType.Ghost,
                PokemonType.Dark,
            });
        }
    }
}